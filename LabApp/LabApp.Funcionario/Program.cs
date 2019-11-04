﻿using System;
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
            Application.Run(new TelaPrincipal());
        }

        private static void pegarLista()
        {
            using (var registroContext = new RegistroContext("RDSDBContext"))
            {
                IList<string> registros = registroContext.Registros.Select(c => "Maq: " + c.NomeMaq + "Id Erro: " + c.IdTipoErro.ToString()).ToList();
                int index = 0;
                foreach (var item in registros)
                {
                    Lista[index] = item;
                    index++;
                }
            }
        }
    }
}
