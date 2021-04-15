using System;
using GameTop.Interface;
using GameTop.Lib;

namespace GameTop
{
    public class JogoFoda
    {
        private readonly IJogador _jogadorA;
        private readonly IJogador _jogadorB;

        public JogoFoda(IJogador jogadorA, IJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        
        public void IniciarJogo()
        {
            Console.WriteLine(_jogadorA.Corre()); 
            Console.WriteLine(_jogadorA.Chuta()); 
            Console.WriteLine(_jogadorA.Passa()); 

            Console.WriteLine("\nPRÓXIMO JOGADOR\n"); 

            Console.WriteLine(_jogadorB.Corre()); 
            Console.WriteLine(_jogadorB.Chuta()); 
            Console.WriteLine(_jogadorB.Passa());         }
    }
}