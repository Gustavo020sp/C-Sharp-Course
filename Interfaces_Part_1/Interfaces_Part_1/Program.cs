using Interfaces_Part_1.Entities;
using System.Diagnostics;
using System.Globalization;
using Interfaces_Part_1.Services;

namespace Interfaces_Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string model;
            DateTime start, end;
            double priceHour, priceDay;

            Console.WriteLine("Enter rental data");

            Console.Write("Car model: ");
            model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            end = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            priceHour = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter price per day: ");
            priceDay = Convert.ToDouble(Console.ReadLine());

            CarRental carRental = new CarRental(start, end, new Vehicle(model));

            RentalService rentalService = new RentalService(priceHour, priceDay, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine(carRental.invoice);

        }
    }
}