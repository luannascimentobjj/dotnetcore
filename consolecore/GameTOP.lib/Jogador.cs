using System;

namespace GameTOP.lib
{
    public class Jogador : IJogador
    {
        public readonly string _Nome;

        public Jogador(string nome)
        {
            _Nome = nome;
        }

        public string chuta()
        {
            return $"{_Nome} está Chutando.\n";
        }
        public string corre()
        {
            return $"{_Nome} está Correndo.\n";
        }
        public string passe()
        {
            return $"{_Nome} está Passando.\n";
        }
    }
}