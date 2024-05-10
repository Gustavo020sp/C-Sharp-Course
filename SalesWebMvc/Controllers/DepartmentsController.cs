using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        List<Department> list = new List<Department>();
        public IActionResult Index()
        {           
            return View(list);
        }
    }
}
