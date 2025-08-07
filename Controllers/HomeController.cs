using AMBA_PRELIM_LAB2.Models;
using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Create Book
            var book = new book
            {
                Id = 1,
                Title = "Alice's Adventures in Wonderland",
                Author = "Lewis Carroll"
            };

            // Create Customer
            var customer = new customer
            {
                FirstName = "John lorenz",
                LastName = "amba",
                MiddleName = "b.",
                Title = "Mr",
                Email = "ambajolo700@gmail.com"
            };

            // Create ViewModel
            var viewModel = new HomeViewModel
            {
                Book = book,
                Customer = customer
            };

            return View(viewModel);
        }
    }
}
