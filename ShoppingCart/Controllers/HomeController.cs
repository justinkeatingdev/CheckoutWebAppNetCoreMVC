using Microsoft.AspNetCore.Mvc;
using ShoppingCartCSET4100.Models;
using System.Diagnostics;

namespace ShoppingCartCSET4100.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Customer CustomerInformation)
        {
            var allItems = Item.GetAllItems();
            allItems = allItems.Where(i => CustomerInformation.CustomerItemNames.Contains(i.ItemName)).ToList();
            CustomerInformation.CustomerItems = allItems;
            return View("OrderComplete", CustomerInformation);
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
