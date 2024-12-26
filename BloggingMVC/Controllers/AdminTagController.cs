using Microsoft.AspNetCore.Mvc;

namespace BloggingMVC.Controllers
{
    
    public class AdminTagController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
