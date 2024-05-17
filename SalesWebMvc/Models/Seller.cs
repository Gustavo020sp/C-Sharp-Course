using System.ComponentModel.DataAnnotations;
using System.Globalization;
namespace SalesWebMvc.Models
{
	public class Seller
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Email { get; set; }

		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
		public DateTime BirthDate { get; set; }

		[DisplayFormat(DataFormatString = "{0:F2}")]
		public double BaseSalary { get; set; }
		public Department? Department { get; set; }
		public int DepartmentId { get; set; }
		public ICollection<SalesRecord> SalesRecord { get; set; } = new List<SalesRecord>();

		public Seller()
		{
		}

		public Seller(int id, string? name, string? email, DateTime birthDate, double baseSalary, Department department)
		{
			baseSalary.ToString("F2", CultureInfo.InvariantCulture);
			Id = id;
			Name = name;
			Email = email;
			BirthDate = birthDate;
			BaseSalary = baseSalary; 			
			Department = department;
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
		public double TotalSales(DateTime initial, DateTime final)
		{
			return SalesRecord.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
		}
	}
}
