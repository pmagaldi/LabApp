﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LabAppLibrary
{
    class Registro
    {
        /// <summary>
        /// Define o registro de erro em uma laboratório de informática
        /// </summary>
        public int Identificacao { get; set; }
        public string NomeLab { get; set; }
        public string NomeMaq { get; set; }
        public DateTime dateTime { get; protected set; }
        protected string Ip { get;  set; }


    }
}
