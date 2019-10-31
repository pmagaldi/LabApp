using System;
using System.Collections.Generic;
using System.Text;

namespace LabAppLibrary.Modelo
{
    public class GruposDeErro
    {
        public int Id { get; internal set; }
        public int IdGrupo { get; set; }
        public int IdTipoErro { get; set; }

        /// <summary>
        /// Construtor da classe Grupos de Erro, ele define quais os erros podem ter em um laboratório.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="idTipo"></param>

        public GruposDeErro(int id, int idTipo)
        {
            if(id <= 0 || idTipo <= 0)
                throw new ArgumentException("Erro nos argumentos do construtor da classe GruposdeErro");
            IdGrupo = id;
            IdTipoErro = idTipo;
        }
    }
}
