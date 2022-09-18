using CrudWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CrudWeb.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            HomeModel home = new HomeModel();
            home.Name = "Roberto";
            home.Email = "frisanco@gmail.com";
            return View(home);
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