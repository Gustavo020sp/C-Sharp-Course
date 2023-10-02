using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalhador_Contratos.Entitites;

namespace Trabalhador_Contratos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Trabalhador trabalhador = new Trabalhador();

            Console.Write("Enter department's name: ");
            string depName = Console.ReadLine();

            Console.WriteLine("WORKER DATA: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Level (Junior/MidLeve/Senior): ");


            Console.ReadLine();
        }
    }
}
