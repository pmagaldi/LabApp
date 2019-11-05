using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabAppLibary.DB;
using LabAppLibrary.Modelo;

namespace LabApp
{
    static class Program
    {
        public static string Ip { get; set; }
        public static string Computername { get; set; }
        public static string[] Lista { get; set; }
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Computername = pegarNomePC();
            Ip = pegarIp();
            Maquina maq = new Maquina(Computername, Ip, pegarIdLab(Computername, Ip));
            listaTipoErro(maq);
            Application.Run(new TelaPrincipal(maq,Lista));
        }

        static void listaTipoErro(Maquina maq)
        {
            using (var Labcont = new LaboratorioContext("RDSDBContext"))
            {
                var lab = Labcont.Laboratorios.FirstOrDefault(c => c.id == maq.IdLab);
                using (var GrupoCont = new GErrosContext("RDSDBContext"))
                {
                    IList<GruposDeErro> TodoErros = GrupoCont.GruposErro.Where(c => c.IdGrupo == lab.IdGrupoErro).ToList();
                    List<int> idDeTodoErros = TodoErros.Select(s => s.IdTipoErro).ToList();
                    using (var tErros = new TErrosContext("RDSDBContext"))
                    {
                        IList<TiposDeErro> tiposDeErros = tErros.TiposErro.ToList();
                        Lista = new string[tiposDeErros.Count];
                        int index = 0;
                        foreach (var item in idDeTodoErros)
                        {
                            if (tiposDeErros.Select(c => c.Id).Equals(item))
                            {
                                Lista[index] = tiposDeErros.Select(c => c.Nome).ToString();
                                index++;
                            }                                
                        }
                    }
                }
            }            
        }

        static int pegarIdLab(string nome, string ip)
        {
            using (var repo = new MaquinaContext("RDSDBContext"))
            {
                var maquina = repo.Maquinas.FirstOrDefault(c => c.Ip == ip);
                return maquina.IdLab;
            }
        }

        static string pegarIp()
        {
            var host = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostAddresses(host);
            string padrao = "[1-2]{1}[0-9]{1,2}[.][0-9]{1,3}[.][0-9]{1,3}[.][0-9]{1,3}";
            foreach (var i in ip)
            {
                var match = Regex.IsMatch(i.ToString(), padrao);
                if (match)
                {
                    Ip = i.ToString();
                    break;
                }
            }
            return Ip.ToString();
        }

        static string pegarNomePC()
        {
            return Environment.MachineName.ToString();
        }
    }
}
