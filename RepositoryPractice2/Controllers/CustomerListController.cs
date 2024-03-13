using Microsoft.AspNetCore.Mvc;

namespace RepositoryPractice2.Controllers
{
    public class CustomerListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
