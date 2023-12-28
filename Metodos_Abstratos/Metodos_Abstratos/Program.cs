using Metodos_Abstratos.Entities;
using System;
using System.Collections.Generic;
using Metodos_Abstratos.Entities.Enum;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Abstratos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Shape> shapeList = new List<Shape>();
            

            Console.WriteLine("Enter the number of shapes: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++ )
            {
                Console.WriteLine($"Shape #{(i+1)} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char resp = Convert.ToChar(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = (Color)Enum.Parse(typeof(Color),Console.ReadLine());

                if (resp == 'r')
                {
                    Console.Write("Width: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Shape shape = new Rectangle(width, height, color);
                    shapeList.Add(shape);
                }
                if(resp == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Shape shape = new Circle(radius, color);
                    shapeList.Add(shape);
                }
            }

            Console.WriteLine("SHAPE AREAS: ");
            
            foreach(Shape shape in shapeList)
            {
                Console.WriteLine(shape.Area());
            }

            Console.ReadLine();

        }
    }
}
