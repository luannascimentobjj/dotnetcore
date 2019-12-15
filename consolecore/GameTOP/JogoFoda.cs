using System;

namespace GameTOP
{
    public class JogoFoda
    {
       private readonly Jogador _jogador;
        public JogoFoda(Jogador jogador)
        {
            _jogador = jogador;
        }
        public void IniciarJogo()
        {
            _jogador.corre();
            _jogador.chuta();
            _jogador.passe();
        }
    }
}