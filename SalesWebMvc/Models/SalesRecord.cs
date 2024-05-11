using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date{ get; set; }
        public double Amount {  get; set; } 
        public SaleStatus Salestatus { get; set; }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus salestatus)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Salestatus = salestatus;
        }
    }
}
