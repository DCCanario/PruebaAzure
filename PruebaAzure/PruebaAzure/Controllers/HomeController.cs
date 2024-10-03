using Microsoft.AspNetCore.Mvc;
using PruebaAzure.Models;
using System.Diagnostics;

namespace PruebaAzure.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int IdUser)
        {
            var user = new Usuario();

            user.Name = "Mati";

            var notas = new List<Nota>()
            {
                new Nota("Nota 1"),
                new Nota("Nota 2")
            };

            user.Notas = notas; 

            return View(user);
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
