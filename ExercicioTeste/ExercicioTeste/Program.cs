using ExercicioTeste.Entities;
using ExercicioTeste.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTeste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string email;
            DateTime birthDay;
            int items;
            string prodName;
            double price = 0;
            int quantity = 0;

            OrderItem order1 = new OrderItem();
            List<OrderItem> orderlist = new List<OrderItem>();

            //pegar dados do cliente
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Email: ");
            email = Console.ReadLine();
            Console.Write("Birth Date: (DD/MM/YYYY): ");
            birthDay = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDay);

            Console.WriteLine();


            Console.WriteLine("Enter order data: ");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Processing");
            Console.WriteLine("Status: " + status);
            Console.Write("How many items to this order? ");
            items = int.Parse(Console.ReadLine());
            Order order = new Order(status);

            for (int i = 0; i < items; i++)
            {
                Console.WriteLine($" Enter #{i+1} item data: ");
                Console.Write("Product name: ");
                prodName = Console.ReadLine();
                Console.Write("Product price: ");
                price = double.Parse(Console.ReadLine());
                Product product = new Product(prodName, price);
                Console.Write("Quantity: ");
                quantity = int.Parse(Console.ReadLine());
                order1 = new OrderItem(quantity, price, product);
                orderlist.Add(order1);
            }

            Console.WriteLine("");
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine("Order moment: " + DateTime.Now);
            Console.WriteLine("Order Status: " + status);
            Console.WriteLine("Client: " + client.name + "(" + client.birthDay + ")" + " - " + client.email);
            Console.WriteLine("");
            Console.WriteLine("ORDER ITEMS");

            double total = 0;

            foreach (OrderItem item in orderlist)
            {
                total = total + item.subTotal();
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Total price: $" + total);


            Console.ReadLine();
        }
    }
}
