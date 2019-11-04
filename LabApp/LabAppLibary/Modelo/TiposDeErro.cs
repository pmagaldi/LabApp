using System;
using System.Collections.Generic;
using System.Text;

namespace LabAppLibrary.Modelo
{
    public class TiposDeErro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        /// <summary>
        /// Construtor da Classe TiposDeErro. Classe que define qual o nome e a descrição de um erro na máquina
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="texto"></param>

        public TiposDeErro(string nome, string texto)
        {
            if(nome == null || texto == null)
                throw new ArgumentException("Erro nos argumentos do construtor da classe TiposDeErro");
            Nome = nome;
            Descricao = texto;
        }

        public TiposDeErro()
        {

        }
    }
}
