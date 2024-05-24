using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using SalesWebMvc.Models;
using SalesWebMvc.Services;
using System.Drawing.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

		// POST: Sellers/Delete
		[HttpPost]
		[AutoValidateAntiforgeryToken]
		public IActionResult Delete(Seller seller)
		{
			_sellerservice.Remove(seller);
			return RedirectToAction("Index");
		}

		// GET: Sellers/Details
		public IActionResult Details(int? id)
		{
			var obj = _sellerservice.FindById(id.Value);
			return View(obj);
		}

		// GET: Sellers/Edit
		public IActionResult Edit(int? id)
		{
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = _sellerservice.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            List<Department> departments = _departmentService.FindAll();
            SellerFormViewModel viewModel = new SellerFormViewModel { seller = obj, Departments = departments };
            return View(viewModel);
        }
	}
}
