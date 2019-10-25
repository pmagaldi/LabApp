using System;

namespace LabAppLibrary.Modelo
{
    public class Laboratorio
    {
        /// <summary>
        /// Classe define uma laborarótio no LabApp
        /// </summary>
        protected int id { get; set; }
        public string Nome { get; protected set; }
        public int _QtdMaq { get; protected set; }
        public int IdGrupoErro { get; protected set; }


        public Laboratorio(string nome, int qtMaq, int Id)
        {
            if (nome == null || qtMaq <= 0 || Id <= 0)
                throw new ArgumentException("Erro nos argumentos do construtor da classe Laboratório");
            Nome = nome;
            _QtdMaq = qtMaq;
            IdGrupoErro = Id;
        }

        public void MudarQtd(int qtd)
        {
            if (qtd <= 0)
                throw new ArgumentException($"Valor da {nameof(qtd)} é invalido");
            _QtdMaq = qtd;
        }

        public void MudarGrupoErro(int id)
        {
            if (id <= 0)
                throw new ArgumentException($"Valor da {nameof(id)} é invalido");
            IdGrupoErro = id;
        }

        public void MudarNome(string nome)
        {
            if (nome == null)
                throw new ArgumentException($"Valor da {nameof(nome)} é invalido");
            Nome = nome;
        }
    }
}
