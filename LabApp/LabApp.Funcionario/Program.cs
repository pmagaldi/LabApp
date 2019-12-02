using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabAppLibary.DB;
using LabAppLibrary.Modelo;

namespace LabApp.Funcionario
{
    static class Program
    {
        public static string[] Lista;
        public static string _DB { get; set; } = "RDSDBContext";
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            pegarLista();
            Application.Run(new TelaPrincipal(Lista));
        }

        internal static string[] pegarLista()
        {
            try
            {
                using (var registroContext = new RegistroContext(_DB))
                {
                    IList<string> registros = registroContext.Registros.OrderByDescending(c => c.Prioridade).Select(c => "Maq: " + c.NomeMaq + " Erro: " + c.IdTipoErro.ToString() + " Dia: " + c.Data.ToString() + " Ip: "+c.Ip.ToString()).ToList();
                    Lista = new string[registros.Count];
                    int index = 0;
                    foreach (var item in registros)
                    {
                        Lista[index] = item;
                        index++;
                    }
                }
            }
            finally
            {
                if (Lista.Length == 0)
                {
                    Lista = new string[1];
                    Lista[0] = "Não tem registro";
                }
            }
            return Lista;
        }

        internal static void deletarRegistro(string item)
        {
            try
            {
                using (var registroContext = new RegistroContext(_DB))
                {
                    var indexIp = item.IndexOf("p") + 3;
                    var indexTipo = item.IndexOf("Erro")+6;
                    var ip = item.Substring(indexIp);
                    var substring = item.Substring(indexTipo, 1);
                    var tipo = Convert.ToInt32(item.Substring(indexTipo, 1));
                    var reg = registroContext.Registros.Where(s => s.Ip == ip && s.IdTipoErro == tipo).FirstOrDefault();
                    registroContext.Registros.Remove(reg);
                    registroContext.SaveChanges();
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
