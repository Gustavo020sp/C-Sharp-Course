using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Parametros_param
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculator sum = new Calculator();

           int soma =  Calculator.Sum(3, 5, 9, 10);

            Console.WriteLine(soma);
            Console.Read();
        }
    }
}
