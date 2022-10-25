using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using TesteInova.Models;

namespace TesteInova.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfigureService _confService;

        public HomeController(ILogger<HomeController> logger, IConfigureService confService)
        {
            _logger = logger;
            _confService = confService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _confService.RecuperaArtigos();
            return View(result);
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