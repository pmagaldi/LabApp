using System;
using System.Collections.Generic;
using System.Text;

namespace LabAppLibrary
{
    class Maquina
    {
        /// <summary>
        /// Classe define uma máquina no LabApp
        /// </summary>
        public string Nome { get; set; }
        public int QtiposErros { get; set; }
        public string Ip { get; protected set; }
    }
}
