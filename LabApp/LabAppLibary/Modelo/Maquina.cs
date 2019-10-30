using System;
using System.Collections.Generic;
using System.Text;

namespace LabAppLibrary.Modelo
{
    public class Maquina
    {
        /// <summary>
        /// Classe define uma máquina no LabApp
        /// </summary>
        public int id { get; internal set; }
        public string Nome { get; set; }
        public string Ip { get; protected set; }
        public int IdLab { get; protected set; }

        /// <summary>
        /// Contrutor de uma máquina no laboratório de informática.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="tipoErro"></param>
        /// <param name="ip"></param>
        /// <param name="lab"></param>

        public Maquina(string nome, string ip, int lab)
        {
            if(nome == null || ip==null || lab <= 0)
                throw new ArgumentException("Erro nos argumentos do construtor da classe Maquina");
            Nome = nome;
            Ip = ip;
            IdLab = lab;
        }
        /// <summary>
        /// Método para alterar o Nome da máquina no banco de dados e no objeto.
        /// </summary>
        /// <param name="novoNome"></param>
        public void MudarNome(string novoNome)
        {
            if(novoNome == null)
                throw new ArgumentException($"Valor do atributo {nameof(novoNome)} é inválido");
            Nome = novoNome;
        }
        /// <summary>
        /// Método para alterar o Ip da máquina no banco de dados e no objeto.
        /// </summary>
        /// <param name="novoIp"></param>
        public void MudarIp(string novoIp)
        {
            if (novoIp == null)
                throw new ArgumentException($"Valor do atributo {nameof(novoIp)} é inválido");
            Ip = novoIp;
        }
        /// <summary>
        /// Método para alterar o Id do laboratório de uma máquina no banco de dados e no objeto.
        /// </summary>
        /// <param name="id"></param>
        public void MudarIdLab(int id)
        {
            if(id <= 0)
                throw new ArgumentException($"Valor do atributo {nameof(id)} é inválido");
            IdLab = id;
        }
    }
}
