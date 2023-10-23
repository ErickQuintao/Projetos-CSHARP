using ControleDeContatos.Models;
using MeuSiteMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MeuSiteMVC.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            HomeModel home = new HomeModel();
            home.Nome = "Erick";
            home.Email = "erickquintao@outlook.com";
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