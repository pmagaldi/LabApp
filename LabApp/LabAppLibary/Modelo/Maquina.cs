using System;
using System.Collections.Generic;
using System.Text;

namespace LabAppLibrary.Modelo
{
    class Maquina
    {
        /// <summary>
        /// Classe define uma máquina no LabApp
        /// </summary>
        protected int id { get; set; }
        public string Nome { get; set; }
        public string Ip { get; protected set; }

        /// <summary>
        /// Contrutor de uma máquina no laboratório de informática.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="tipoErro"></param>
        /// <param name="ip"></param>

        public Maquina(string nome, int tipoErro, string ip)
        {
            if(nome == null || tipoErro == null || ip==null)
                throw new ArgumentException("Erro nos argumentos do construtor da classe Maquina");
            Nome = nome;
            QtiposErros = tipoErro;
            Ip = ip;
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
    }
}
