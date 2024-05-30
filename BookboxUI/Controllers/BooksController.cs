using Microsoft.AspNetCore.Mvc;

namespace BookboxUI.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
