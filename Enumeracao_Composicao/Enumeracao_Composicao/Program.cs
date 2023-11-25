using Enumeracao_Composicao.Entities;
using Enumeracao_Composicao.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracao_Composicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            //lista dos produtos
            var product_list = new List<Product>();

            //client data
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYY):  ");
            DateTime bday = Convert.ToDateTime(Console.ReadLine());

            Client client = new Client(name, email, bday);

            Console.WriteLine();
            //order data
            Console.WriteLine("Enter order data: ");
            Console.WriteLine("Status: " + OrderStatus.PROCESSING);
            Console.Write("How many items to this order? ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter #" + (i+1) + " item data: ");
                Console.Write("Product name: ");
                string product_name = Console.ReadLine();
                Console.Write("Product price: ");
                double product_price = Convert.ToDouble(Console.ReadLine());
                Console.Write("Quantity: ");
                int product_quantity = Convert.ToInt32(Console.ReadLine());
                Product product = new Product(product_name, product_price, product_quantity);
                product.AddValue();
                product_list.Add(product);
            }

            Console.WriteLine();
            //abaixo mostrar dados do cliente e produto//
            Console.WriteLine("ORDER SUMARY: ");
            Console.WriteLine("Order moment: " + DateTime.Now.ToString());
            Console.WriteLine("Order Status: " + OrderStatus.PROCESSING);
            Console.WriteLine("Client: " + client.name + ", " + "(" + client.bday + ")" + ", " + client.email);
            Console.WriteLine();
            Console.WriteLine("Order Items: ");

            //mostrar lista final de produtos
            foreach (Product product in product_list)
            {
                Console.WriteLine(product.ToString());
            }

            //final price order
            foreach(Product product in product_list)
            {
                 order.total_price = order.total_price + product.product_price * product.product_quantity;
            }

            Console.WriteLine("Total price: $" + order.total_price);
            Console.Read();
        }
    }
}
