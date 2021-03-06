﻿using System;
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
        public static string Ip { get;internal set; }
        public static string Computername { get;internal set; }
        public static string Labname { get;internal set; }
        public static int idGrupo { get; internal set; }
        public static string[] Lista { get;internal set; }
        public static string _DB { get; set; } = "RDSDBContext";
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
            try
            {
                Maquina maq = new Maquina(Computername, Ip, pegarIdLab(Computername, Ip));
                listaTipoErro(maq);
                Application.Run(new TelaPrincipal(maq, Lista));
            }
            catch(Exception ex)
            {
                Application.Run(new TelaPrincipal("Computador não cadastrado"));
                MessageBox.Show(ex.Message);
            }
        }

        static void listaTipoErro(Maquina maq)
        {
            try
            {
                using (var Labcont = new LaboratorioContext(_DB))
                {
                    var lab = Labcont.Laboratorios.FirstOrDefault(c => c.Id == maq.IdLab);
                    Labname = lab.Nome;
                    idGrupo = lab.IdGrupoErro;
                    using (var GrupoCont = new GErrosContext(_DB))
                    {
                        IList<GruposDeErro> TodoErros = GrupoCont.GruposErro.Where(c => c.IdGrupo == lab.IdGrupoErro).ToList();
                        List<int> idDeTodoErros = TodoErros.Select(s => s.IdTipoErro).ToList();
                        using (var tErros = new TErrosContext(_DB))
                        {
                            IList<TiposDeErro> tiposDeErros = tErros.TiposErro.ToList();
                            Lista = new string[idDeTodoErros.Count];
                            int index = 0;
                            foreach (var item in idDeTodoErros)
                            {
                                if (tiposDeErros.Select(s => s.Id).Contains(item))
                                {
                                    var nome = tiposDeErros.FirstOrDefault(s => s.Id == item).Nome;
                                    Lista[index] = nome;
                                    index++;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        static int pegarIdLab(string nome, string ip)
        {
            using (var repo = new MaquinaContext(_DB))
            {
                var maquina = repo.Maquinas.FirstOrDefault(c => c.Ip == ip);
                return maquina.IdLab;
            }
        }

        static string pegarIp()
        {
            var host = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostAddresses(host);
            string padrao = "[10]{1}[.][0-9]{1,3}[.][0-9]{1,3}[.][0-9]{1,3}";
            foreach (var i in ip)
            {
                var match = Regex.IsMatch(i.ToString(), padrao);
                if (match)
                {
                    Ip = i.ToString();
                    break;
                }
            }
            if (Ip != null)
                return Ip.ToString();
            else
                return "Não cadastrado";
        }

        static string pegarNomePC()
        {
            return Environment.MachineName.ToString();
        }

        public static void Registro(string texto)
        {
            try
            {
                int index;
                int preferencia;
                using (var tipoContext = new TErrosContext(_DB))
                {
                    var tipo = tipoContext.TiposErro.Where(s => s.Nome == texto).FirstOrDefault();
                    index = tipo.Id;
                    preferencia = tipo.Prioridade;
                }
                using (var regContext = new RegistroContext(_DB))
                {
                    regContext.Registros.Add(new Registro(Labname, Computername, Ip, index, idGrupo,preferencia));
                    regContext.SaveChanges();
                    MessageBox.Show("Realizado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
