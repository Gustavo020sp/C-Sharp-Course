using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System.Collections.Generic;

namespace SalesWebMvc.Services
{
	public class SellerService
	{
		private readonly SalesWebMvcContext _context;

		public SellerService(SalesWebMvcContext context)
		{
			_context = context;
		}

		public List<Seller> FindAll()
		{
			return _context.Seller.ToList();
		}
		public void Insert(Seller obj)
		{
			//obj.Department = _context.Department.First();
			_context.Add(obj);
			_context.SaveChanges();
		}

		public void Remove(Seller obj)
		{
			//obj.Department = _context.Department.First();
			_context.Remove(obj);
			_context.SaveChanges();
		}

		public Seller FindById(int id)
		{
			return _context.Seller.FirstOrDefault(obj => obj.Id == id);
		}
	}
}
