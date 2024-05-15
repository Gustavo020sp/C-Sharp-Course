using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;
using System.Drawing.Text;

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
    }
}
