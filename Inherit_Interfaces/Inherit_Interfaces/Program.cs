//using System;
using Inherit_Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle { color = Enums.Color.Red, height = 10, width = 20};
            Triangle triangle = new Triangle { color = Enums.Color.Green, height = 50, width = 30};

            Console.WriteLine(rectangle.ToString());
            Console.WriteLine(triangle.ToString()); 

            Console.ReadLine();
        }
    }
}
