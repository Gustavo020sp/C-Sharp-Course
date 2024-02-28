namespace Interfaces_Part_1.Entities
{
    public class CarRental
    {
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public Vehicle vehicle { get; set; }
        public Invoice invoice { get; set; }

        //Invoice só vai ser chamado quando processar o aluguel de carro
        public CarRental(DateTime start, DateTime end, Vehicle vehicle)
        {
            this.start = start;
            this.end = end;
            this.vehicle = vehicle;
        }
    }
}
