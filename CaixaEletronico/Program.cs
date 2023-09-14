using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PessoaFisica P1;

            Console.Write("Entre o número da conta: ");
            int numeroconta = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial? [s/n] ");
            char resposta = Convert.ToChar(Console.ReadLine());



            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double depositoinicial = Convert.ToDouble(Console.ReadLine());
                P1 = new PessoaFisica(nome, numeroconta, depositoinicial);
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(P1.ToString());

            }
            else
            {
                Console.WriteLine("Dados da conta: ");
                P1 = new PessoaFisica(nome, numeroconta);
                Console.WriteLine(P1.ToString());
            }

            Console.WriteLine("Entre com uma opção: ");
            Console.WriteLine("[1] - SAQUE");
            Console.WriteLine("[2] - DEPÓSITO");

            char opcao = Convert.ToChar(Console.Read());

            if (opcao == '1')
            {
                goto valorsaque;
            }

            if (opcao == '2')
            {
                goto valordeposito;
            }

valordeposito:

            Console.Write("Entre um valor para depósito: ");
            double valordeposito2 = Convert.ToDouble(Console.ReadLine());
            P1.SomarValorDeposito(valordeposito2);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(P1.ToString());

valorsaque:
            Console.Write("Entre um valor para saque: ");
            double valorsaque = Convert.ToDouble(Console.ReadLine());
            P1.SomarValorSaque(valorsaque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(P1.ToString());


            Console.ReadLine();
        }
    }
}
