using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DonanimMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DonanimMVC.Controllers
{
    public class HomeController : Controller
    {
        TestManager tm = new TestManager(new EFTestRepository());
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var values = tm.GetList();
            return View(values);
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
    }
}