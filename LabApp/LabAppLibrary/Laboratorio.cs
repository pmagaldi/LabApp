using System;

namespace LabAppLibrary
{
    public class Laboratorio
    {
        public string Nome { get; set; }
        public int _QtdMaq { get; protected set; }
        public Laboratorio(string nome, int qtd)
        {
            Nome = nome;
            _QtdMaq = qtd;
        }

    }
}
