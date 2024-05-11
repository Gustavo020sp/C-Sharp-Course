namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string? Name { get; set; } 
        public DateTime BirthDate { get; set; }
        public double BaseSalary{ get; set; }
        public ICollection<Department>? Department { get; set; }
        public ICollection<SalesRecord> SalesRecord { get; set; }    

        public Seller(int id, string? name, DateTime birthDate, double baseSalary)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
        }

        public void addSales(SalesRecord sr)
        {
            SalesRecord.Add(sr);
        }
        public void removeSales(SalesRecord sr)
        {
            SalesRecord.Remove(sr);
        }


        //pensar sobre como desenvolver
        //public double totalSales(DateTime initial, DateTime final)
        //{

        //    SalesRecord.Where(x => x.Amount)
        //}
    }
}
