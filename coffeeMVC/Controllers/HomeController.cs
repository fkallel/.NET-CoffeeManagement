using coffeeMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace coffeeMVC.Controllers
{
    public class HomeController : Controller

    {
        private readonly Data.CoffeManagementmvcContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Admin()
        {
            return View();
        }
        public IActionResult Hello()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Choice()
        {
            return View();
        }
        public IActionResult Pizza()
        {
            var pizzaProducts = _context.Products.Where(p => p.Name == "PIZZA").ToList();
            return View(pizzaProducts);
        }
        public IActionResult Plat()
        {
            var platProducts = _context.Products.Where(p => p.Name == "PLAT").ToList();
            return View(platProducts);
        }

    }
}