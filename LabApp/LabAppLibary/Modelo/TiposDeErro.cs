using System;
using System.Collections.Generic;
using System.Text;

namespace LabAppLibrary.Modelo
{
    public class TiposDeErro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Prioridade { get; set; }
        public string Descricao { get; set; }

        /// <summary>
        /// Construtor da Classe TiposDeErro. Classe que define qual o nome e a descrição de um erro na máquina
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="texto"></param>
        /// <param name="prio"></param>

        public TiposDeErro(string nome, string texto, int prio)
        {
            if(nome == null || texto == null || prio == 0)
                throw new ArgumentException("Erro nos argumentos do construtor da classe TiposDeErro");
            Nome = nome;
            Descricao = texto;
            Prioridade = prio;
        }

        public TiposDeErro()
        {

        }
    }
}
