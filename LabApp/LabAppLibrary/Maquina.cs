using System;
using System.Collections.Generic;
using System.Text;

namespace LabAppLibrary
{
    class Maquina
    {
        public string Nome { get; set; }
        public int Qtipos { get; set; }
        public string Ip { get; protected set; }
        public int Numero { get; protected set; }
    }
}
