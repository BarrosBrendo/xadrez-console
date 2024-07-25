using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        public static void Main(string[] args)
        {
            Tabuleiro Tab = new Tabuleiro(8, 8);
            Tela.imprimirTabuleiro(Tab);
            Console.ReadLine();
        }
    }
}
