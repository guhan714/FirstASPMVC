using First.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace First.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public ActionResult Random()
        {
            return View();
        }
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;

            }
            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";

            }

            return Content($"PageIndex={pageIndex}&SortBy={sortBy}");
        }
    }
}
