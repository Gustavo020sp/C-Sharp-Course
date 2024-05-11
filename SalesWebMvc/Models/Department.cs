namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; } 
        public ICollection<Seller>? Sellers { get; set; } = new List<Seller>();

        public Department(int id, string? name)
        {
            Id = id;
            Name = name;
        }

        public Department()
        {
        }

        public void addSeller(Seller seller)
        {
            Sellers?.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            //return Sellers.Where(sl => sl.SalesRecord.Where(sr => sr.Date <= initial && sr.Date >= final).Sum());
            return Sellers.Sum(sl => sl.TotalSales(initial, final));
        }
    }
}