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

        private static void pegarLista()
        {
            try
            {
                using (var registroContext = new RegistroContext("RDSDBContext"))
                {
                    IList<string> registros = registroContext.Registros.Select(c => "Maq: " + c.NomeMaq + " Id Erro: " + c.IdTipoErro.ToString()).ToList();
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
        }

        internal static void deletarRegistro(int index)
        {
            try
            {
                using (var registroContext = new RegistroContext("RDSDBContext"))
                {
                    Registro reg = registroContext.Registros.FirstOrDefault(s => s.Id == index);
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
