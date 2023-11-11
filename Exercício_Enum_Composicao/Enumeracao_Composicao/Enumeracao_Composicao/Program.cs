using Enumeracao_Composicao.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracao_Composicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            //Client data
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            client.name = Console.ReadLine();
            Console.Write("Email: ");
            client.email = Console.ReadLine();
            Console.WriteLine("Birth date: ");
            client.bday = Console.ReadLine();

            //Order data
            Console.WriteLine("Enter order data: ");
            Order order = new Order();
            Console.WriteLine("Stauts: " + order.status); // --> arrumar enumerator

            Console.Write("How many items to this order?");
            int n = Convert.ToInt32(Console.ReadLine());

            Product product = new Product();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter #" + (i+1) + " item data: ");
                Console.Write("Product name: ");
                product.name = Console.ReadLine();               
                Console.Write("Product price: ");
                product.price = Convert.ToDouble(Console.ReadLine());
                OrderItem orderItem = new OrderItem();
                Console.Write("Quantity: ");
                orderItem.quantity = Convert.ToInt32(Console.ReadLine());
                product.AddItem(orderItem);
            }

            order.ToString();
            //Console.WriteLine("ORDER SUMMARY: ");
            //Console.WriteLine("Order moment: " + order.moment);
            //Console.WriteLine("Order status: " + order.status);
            //Console.WriteLine("Client: " + client.name + " " + client.bday + " - " + client.email);

            //Console.WriteLine("Order Items: ");


            Console.Read();
        }
    }
}
