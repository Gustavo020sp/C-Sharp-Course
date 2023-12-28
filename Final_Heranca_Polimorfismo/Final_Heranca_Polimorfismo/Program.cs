using Final_Heranca_Polimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Heranca_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> listproducts = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{(i+1)} data: ");
                Console.Write("Common, used or imported? ");
                char prod_type = Convert.ToChar(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                if (prod_type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = Convert.ToDouble(Console.ReadLine());
                    Product product = new ImportedProduct(customsFee, name, price);
                    listproducts.Add(product);
                }
                else if(prod_type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYY): ");
                    DateTime manufactureDate = Convert.ToDateTime(Console.ReadLine());
                    Product product = new usedProduct(manufactureDate, name, price);
                    listproducts.Add(product);
                }
                else
                {
                    Product product = new Product(name, price);
                    listproducts.Add(product);
                }

            }

            Console.WriteLine("Price tags: ");

            foreach (Product product in listproducts)
            {
                Console.WriteLine(product.priceTag());
            }

            Console.ReadLine();
        }
    }
}
