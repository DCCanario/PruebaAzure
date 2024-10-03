using Microsoft.AspNetCore.Mvc;

namespace PruebaAzure.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult SingIn()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
    }
}
