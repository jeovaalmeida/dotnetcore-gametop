using System;
using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador1 : IJogador
    {
        public readonly string _nome;

        public Jogador1(string nome = "Ronaldo")
        {
            _nome = nome;
        }

        public string Chuta()
        {
            return $"{_nome} está chutando";
        }

        public string  Corre()
        {
            return $"{_nome} está correndo";
        }

        public string  Passa()
        {
            return $"{_nome} está passendo";
        }
   }
}