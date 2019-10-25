using System;
using System.Collections.Generic;
using System.Text;

namespace LabAppLibrary.Modelo
{
    class Registro
    {
        /// <summary>
        /// Define o registro de erro em uma laboratório de informática
        /// </summary>
        protected int Id { get; set; }
        protected string NomeLab { get; set; }
        public string NomeMaq { get; set; }
        public DateTime Data { get; protected set; }
        protected string Ip { get;  set; }
        public int IdTipoErro { get; set; }
        public int IdGrupoErro { get; set; }

        public Registro(string lab, string maq, string ip, int idTipo, int idGrupo)
        {
            NomeLab = lab;
            NomeMaq = maq;
            Ip = ip;
            IdTipoErro = idTipo;
            IdGrupoErro = idGrupo;
            Data = DateTime.Today;
        }

        //funções para mudar o registro?
    }
}
