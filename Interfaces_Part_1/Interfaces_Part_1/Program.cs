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
			string model, response;
			DateTime start, end;
			double priceHour, priceDay;

			do
			{
				Console.Write("Enter Country(BR/USA): ");
				string country = Console.ReadLine();

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

				if (country == "BR")
				{
					RentalService rentalService = new RentalService(priceHour, priceDay, new BrazilTaxService());
					rentalService.ProcessInvoice(carRental);
				}
				else
				{
					RentalService rentalService = new RentalService(priceHour, priceDay, new UsaTaxService());
					rentalService.ProcessInvoice(carRental);
				}

				Console.WriteLine(carRental.invoice);
				Console.WriteLine("--------------------------------");
				Console.Write("Do you wish to make another rent service? ");
				response = Console.ReadLine();

			} while (response == "Y");
		}
	}
}