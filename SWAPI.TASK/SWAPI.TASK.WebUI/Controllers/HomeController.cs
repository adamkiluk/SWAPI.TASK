using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SWAPI.TASK.WebUI.Models;

namespace SWAPI.TASK.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public Task<IActionResult> Index()
        {
            HomeViewModel model = new HomeViewModel();
            string url = $"https://swapi.dev/api/films/";
            FilmDto filmDto = FetchSwapiData<FilmDto>(url);

            model.FilmDto = filmDto;
            return View(model);
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

        private static T1 FetchSwapiData<T1>(string url)
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync(url).Result;
            string content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<T1>(content);
            return result;
        }
    }
}
