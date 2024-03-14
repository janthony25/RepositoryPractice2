using Microsoft.AspNetCore.Mvc;
using RepositoryPractice2.Repository;

namespace RepositoryPractice2.Controllers
{
    public class CustomerListController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerListController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;   
        }
        public IActionResult Index()
        {
            ViewBag.CustomerListWithIssue = _customerRepository.GetCustomer();
            return View();
        }
    }
}
