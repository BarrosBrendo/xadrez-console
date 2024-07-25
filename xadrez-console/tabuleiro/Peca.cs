namespace tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimento { get; set; }
        public Tabuleiro Tab { get; set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {
            Posicao = posicao;
            Cor = cor;
            Tab = tab;
            QteMovimento = 0;
        }

    }
}
