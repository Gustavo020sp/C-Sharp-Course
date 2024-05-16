using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;
using System.Drawing.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SalesWebMvc.Controllers
{
	public class SellersController : Controller
	{
		private readonly SellerService _sellerservice;

		public SellersController(SellerService sellerservice)
		{
			_sellerservice = sellerservice;
		}

		public IActionResult Index()
		{
			return View(_sellerservice.FindAll());
		}

		//GET action Sellers/Create // retorna a tela para criar um novo user
		public IActionResult Create()
		{
			return View();
		}

		//POST action Sellers/Create // ao clicar em "create" o método vai ser chamado como POST
		[HttpPost]
		[AutoValidateAntiforgeryToken]
		public IActionResult Create(Seller seller)
		{
			_sellerservice.Insert(seller);
			return RedirectToAction("Index");
		}


	}
}
