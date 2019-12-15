using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda(new Jogador("Cristiano Ronaldo"));
            jogo.IniciarJogo();
        }
    }

}
