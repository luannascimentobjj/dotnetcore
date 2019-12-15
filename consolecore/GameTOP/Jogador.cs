using System;

namespace GameTOP
{
    public class Jogador
    {
        public readonly string _Nome;

        public Jogador(string nome)
        {
            _Nome = nome;
        }

        public void chuta()
        {
            Console.Write($"{_Nome} está Chutando.\n");
        }
        public void corre()
        {
            Console.Write($"{_Nome} está Correndo.\n");
        }
        public void passe()
        {
            Console.Write($"{_Nome} está Passando.\n");
        }
    }
}