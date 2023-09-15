using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre com os dados do produto: ");
            string nome = Console.ReadLine();
            double preco = Convert.ToInt32(Console.ReadLine());
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Produto produto = new Produto(nome, preco, quantidade);

            Console.WriteLine("");

            Console.Write("Dados do produto: " + produto.ToString());

            Console.WriteLine("");

            Console.Write("Digite o número de produtos a serem adicionados: ");
            quantidade = Convert.ToInt32(Console.ReadLine());
            produto.AdicionarProdutos(quantidade);

            Console.WriteLine("Dados atualizados: " + produto.ToString());

            Console.Write("Digite o número de produtos a serem removidos: ");
            quantidade = Convert.ToInt32(Console.ReadLine());
            produto.RemoverProdutos(quantidade);

            Console.WriteLine("Dados atualizados: " + produto.ToString());

            Console.ReadLine();
        }
    }
}
