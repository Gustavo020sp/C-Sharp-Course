using Expressoes_Lambda.Entities;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Expressoes_Lambda
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] prods;
            string path = @"D:\Projects\C-Sharp-Course\Expressoes_Lambda\products.csv";
            List<Product> products = new List<Product>();

            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    prods = sr.ReadLine().Split(",");
                    string name = prods[0];
                    double value = double.Parse(prods[1], CultureInfo.InvariantCulture);
                    products.Add(new Product(name, value));
                }
            }

            foreach (var p in products)
            {
                Console.WriteLine(p.Price.ToString("F2", CultureInfo.InvariantCulture));
            }


            //criar expressoes lambda usando o LINQ

            //calculate the avarage of all numbers accessing the list
            var avg = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine();
            Console.WriteLine("Avarege: ");
            Console.WriteLine(avg.ToString("F2", CultureInfo.InvariantCulture));

            //calculate the sum of all numbers accessing the list
            var sum = products.Select(p => p.Price).DefaultIfEmpty(0.0).Sum();
            Console.WriteLine();
            Console.WriteLine("Sum: ");
            Console.WriteLine(sum.ToString("F2", CultureInfo.InvariantCulture));

            //show the products lower then avg ordered in decrescent names
            var names = products.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            Console.WriteLine();
            Console.WriteLine("Names: ");
            foreach (var p in names)
            {
                Console.WriteLine(p);
            }

            Console.ReadLine();
        }
    }
}
