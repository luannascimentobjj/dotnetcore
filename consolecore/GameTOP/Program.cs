using System;
using GameTOP.lib;

namespace GameTOP.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda(
                new Jogador("Cristiano Ronaldo"),
                new Jogador2());
            jogo.IniciarJogo();
        }
    }

}
