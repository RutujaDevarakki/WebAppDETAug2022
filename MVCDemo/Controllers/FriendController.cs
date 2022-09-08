using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class FriendController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
