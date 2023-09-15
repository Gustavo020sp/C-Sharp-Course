using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_For_Each
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] vect = new string[] { "Maria", "Bob", "Kaua", "Marley" };

            foreach(var obj in vect) { Console.WriteLine(obj); }

            Console.ReadLine();
        }
    }
}
