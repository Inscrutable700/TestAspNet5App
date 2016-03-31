using Microsoft.AspNet.Mvc;
using TestAspNet5App.ViewModels;

namespace TestAspNet5App.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            BookViewModel model = new BookViewModel
            {
              Name = "Test",
              ID = 1,
            };
            
            return View(model);
        }
    }
}
