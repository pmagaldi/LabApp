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
            //listaTipoErro(maq);
            Application.Run(new TelaPrincipal(maq));
        }

        static void listaTipoErro(Maquina maq)
        {
            //primeiro pegar lab
            IList<GruposDeErro> GruposErrosSelecionados = new List<GruposDeErro>();
            using (var Labcont = new LaboratorioContext("RDSDBContext"))
            {
                var lab = Labcont.Laboratorios.FirstOrDefault(c => c.id == maq.IdLab);
                using (var GrupoCont = new GErrosContext("RDSDBContext"))
                {
                    IList<GruposDeErro> TodoErros = GrupoCont.GruposErro.ToList();                    
                    foreach (var item in TodoErros)
                    {
                        if (item.IdGrupo == lab.IdGrupoErro)
                            GruposErrosSelecionados.Add(item);
                    }
                }
            }
            using (var repo = new TErrosContext("RDSDBContext"))
            {
                IList<TiposDeErro> erros = repo.TiposErro.ToList();
                foreach (var item in erros)
                {
                    if(item.Id == )
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
