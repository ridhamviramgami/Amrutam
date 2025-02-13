using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Amrutam.Controllers
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
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
