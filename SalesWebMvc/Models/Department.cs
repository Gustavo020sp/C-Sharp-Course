namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; } 
        public ICollection<Seller>? Seller { get; set; }

        public Department(int id, string? name)
        {
            Id = id;
            Name = name;
        }

        public void addSeller(Seller seller)
        {
            Seller?.Add(seller);
        }
        //public double totalSales()
        //{

        //}
    }
}
