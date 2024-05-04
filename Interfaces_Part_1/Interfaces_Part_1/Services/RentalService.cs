using Interfaces_Part_1.Entities;
namespace Interfaces_Part_1.Services
{
    public class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        //não é a nmelhor forma abaixo
        //private BrazilTaxService _braziltaxservice = new BrazilTaxService();

        //merlhor forma -> instanciar a interface
        private ITaxService Taxservice;
        public RentalService(double pricePerHour, double pricePerDay, ITaxService Taxservice)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            this.Taxservice = Taxservice;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            //aqui calcula a duração do aluguel
            TimeSpan duration = carRental.end.Subtract(carRental.start);
            double basicPayment = 0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = Taxservice.Tax(basicPayment);

            carRental.invoice = new Invoice(basicPayment, tax);
        }
    }
}
