using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;
using SalesWebMvc.Services;
using System.Drawing.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SalesWebMvc.Controllers
{
	public class SellersController : Controller
	{
		private readonly SellerService _sellerservice;
		private readonly DepartmentService _departmentService;

		public SellersController(SellerService sellerservice, DepartmentService departmentService)
		{
			_sellerservice = sellerservice;
			_departmentService = departmentService;
		}

		public IActionResult Index()
		{
			return View(_sellerservice.FindAll());
		}

		//GET action Sellers/Create // retorna a tela para criar um novo user
		public IActionResult Create()
		{
			var departments = _departmentService.FindAll();
			var viewmodel = new SellerFormViewModel { Departments = departments };
			return View(viewmodel);
		}

		//POST action Sellers/Create // ao clicar em "create" o método vai ser chamado como POST
		[HttpPost]
		[AutoValidateAntiforgeryToken]
		public IActionResult Create(Seller seller)
		{
			_sellerservice.Insert(seller);
			return RedirectToAction("Index");
		}


		// GET: Sellers/Delete
		public IActionResult Delete(int? id)
		{
			var obj = _sellerservice.FindById(id.Value);
			return View(obj);
		}
	}
}
