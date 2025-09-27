using Microsoft.AspNetCore.Mvc;
using SM_ProyectoWebMVC.Models;
using System.Diagnostics;

namespace SM_ProyectoWebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registro()
        {
            return View();
        }
        public IActionResult Principal()
        {
            return View();
        }
    }
}
