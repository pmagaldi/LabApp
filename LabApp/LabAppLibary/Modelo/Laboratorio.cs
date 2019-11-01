using System;

namespace LabAppLibrary.Modelo
{
    public class Laboratorio
    {
        /// <summary>
        /// Classe define um laborarótio no LabApp
        /// </summary>
        public int id { get;internal set; }
        public string Nome { get;  set; }
        public int _QtdMaq { get;  set; }
        public int IdGrupoErro { get;  set; }

        /// <summary>
        /// Construtor de um laboratório de informática.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="qtMaq"></param>
        /// <param name="Id"></param>

        public Laboratorio(string nome, int qtMaq, int Id)
        {
            if (nome == null || qtMaq <= 0 || Id <= 0)
                throw new ArgumentException("Erro nos argumentos do construtor da classe Laboratório");
            Nome = nome;
            _QtdMaq = qtMaq;
            IdGrupoErro = Id;
        }
        public Laboratorio()
        {

        }
        /// <summary>
        /// Metódo para alterar o valor da quantidade de máquina no banco de dados e no objeto.
        /// </summary>
        /// <param name="qtd"></param>
        public void MudarQtd(int qtd)
        {
            if (qtd <= 0)
                throw new ArgumentException($"Valor da {nameof(qtd)} é invalido");
            _QtdMaq = qtd;
        }
        /// <summary>
        /// Metódo para alterar o grupo de erros do laboratório no banco de dados e no objeto.
        /// </summary>
        /// <param name="id"></param>
        public void MudarGrupoErro(int id)
        {
            if (id <= 0)
                throw new ArgumentException($"Valor da {nameof(id)} é invalido");
            IdGrupoErro = id;
        }
        /// <summary>
        /// Metódo para alterar o nome do laboratório no banco de dados e no objeto.
        /// </summary>
        /// <param name="nome"></param>
        public void MudarNome(string nome)
        {
            if (nome == null)
                throw new ArgumentException($"Valor da {nameof(nome)} é invalido");
            Nome = nome;
        }
    }
}
