using System;

namespace GameTOP
{
    public class JogoFoda
    {

        private readonly IJogador _jogador1;
        private readonly IJogador _jogador2;

       private readonly IJogador _jogador;
        public JogoFoda(IJogador jogador1, IJogador jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }
        public void IniciarJogo()
        {
            System.Console.Write(_jogador1.corre());
            System.Console.Write(_jogador1.chuta());
            System.Console.Write(_jogador1.passe());
            
            System.Console.Write("Próximo jogador \n");

            System.Console.Write(_jogador2.corre());
            System.Console.Write(_jogador2.chuta());
            System.Console.Write(_jogador2.passe());
        }
    }
}