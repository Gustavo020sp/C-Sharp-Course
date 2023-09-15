using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TipoStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double? x = null;
            double? y = 10;

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("O Valor de x é nullo, verifique");
            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("erro");

            Console.ReadLine();

        }
    }
}
