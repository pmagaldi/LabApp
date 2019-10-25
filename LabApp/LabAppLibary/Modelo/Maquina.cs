using System;
using System.Collections.Generic;
using System.Text;

namespace LabAppLibrary.Modelo
{
    class Maquina
    {
        /// <summary>
        /// Classe define uma máquina no LabApp
        /// </summary>
        protected int id { get; set; }
        public string Nome { get; set; }
        public int QtiposErros { get; set; }
        public string Ip { get; protected set; }

        public Maquina(string nome, int tipoErro, string ip)
        {
            if(nome == null || )
        }
    }
}
