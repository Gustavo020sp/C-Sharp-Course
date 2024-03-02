using Projeto_Xadrez_ConsoleApp.tabuleiro;

namespace Projeto_Xadrez_ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);

        }
    }
}