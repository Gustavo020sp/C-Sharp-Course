using Projeto_Xadrez_ConsoleApp.Tabuleiro;

namespace Projeto_Xadrez_ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Posicao p;

            p = new Posicao(3, 4);

            Console.WriteLine(p.ToString());
        }
    }
}