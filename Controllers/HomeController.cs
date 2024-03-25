using Darla.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Darla.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
