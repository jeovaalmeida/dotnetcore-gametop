using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : IJogador
    {
        public string Chuta()
        {
            return $"Maradonaa está patiendo";
        }

        public string Corre()
        {
            return $"Maradonaa está coriendo";
        }

        public string Passa()
        {
            return $"Maradonaa está pasando";
        }
    }
}