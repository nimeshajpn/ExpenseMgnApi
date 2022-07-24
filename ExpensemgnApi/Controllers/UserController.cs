using Microsoft.AspNetCore.Mvc;

namespace ExpensemgnApi.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
