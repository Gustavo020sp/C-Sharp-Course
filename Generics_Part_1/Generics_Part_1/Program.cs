using Generics_Part_1.Services;
using System.Security.Cryptography.X509Certificates;

namespace Generics_Part_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("How many values? ");
            int values = int.Parse(Console.ReadLine());

            PrintService<string> printService = new PrintService<string>(values);

            printService.addValue(values);
            printService.print();
        }
    }
}