using System;
using System.Collections.Generic;
using System.Text;

namespace LabAppLibrary.Modelo
{
    class GruposDeErro
    {
        public int Id { get; set; }
        public int IdGrupo { get; set; }
        public int TipoErro { get; set; }

        /// <summary>
        /// Construtor da classe Grupos de Erro, ele define quais os erros podem ter em um laboratório.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tipo"></param>

        public GruposDeErro(int id, int tipo)
        {
            if(id <= 0 || tipo <= 0)
                throw new ArgumentException("Erro nos argumentos do construtor da classe GruposdeErro");
            IdGrupo = id;
            TipoErro = tipo;
        }
    }
}
