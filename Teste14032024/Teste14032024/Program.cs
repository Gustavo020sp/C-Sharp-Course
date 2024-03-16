using Teste14032024.Entities;
using System.Globalization;

namespace Teste14032024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string carModel;
            DateTime start;
            DateTime end;
            double priceHour;
            double priceDay;
            
            Console.WriteLine("ENTER RENTAL DATA:  ");
            Console.Write("Car model: ");
            carModel = Console.ReadLine();
            Console.Write("Pick-up (dd/MM/yyyy hh:mm): ");
            start = DateTime.Parse(Console.ReadLine(), (System.Globalization.CultureInfo.CreateSpecificCulture("Pt-Br")));
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            end = DateTime.Parse(Console.ReadLine(),(System.Globalization.CultureInfo.CreateSpecificCulture("Pt-Br")));
            Console.Write("Enter price per hour: ");
            priceHour = Double.Parse(Console.ReadLine());
            Console.Write("Enter price per day: ");
            priceDay = Double.Parse(Console.ReadLine());
            Console.WriteLine("INVOICE: ");

            Contract contract1 = new Contract(carModel, start, end, priceHour, priceDay);

            contract1.Calculate();

            Console.WriteLine(contract1.ToString());

            Console.ReadLine();



        }
    }
}