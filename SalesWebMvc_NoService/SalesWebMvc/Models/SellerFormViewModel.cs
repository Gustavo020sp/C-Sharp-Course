namespace SalesWebMvc.Models
{
	public class SellerFormViewModel
	{
		public Seller? seller {  get; set; }
		public ICollection<Department>? Departments { get; set; }
	}
}
