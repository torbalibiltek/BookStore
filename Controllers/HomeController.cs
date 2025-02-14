using System.Diagnostics;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        List<Kitap> liste = new List<Kitap>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            liste.Add(new Kitap() { Id = 1, KitapAd = "ASP.NET Core MVC", Fiyat = 50 });
            liste.Add(new Kitap() { Id = 2, KitapAd = "Angular", Fiyat = 60 });
            liste.Add(new Kitap() { Id = 3, KitapAd = "React", Fiyat = 70 });
            liste.Add(new Kitap() { Id = 4, KitapAd = "Vue.js", Fiyat = 80 });
            liste.Add(new Kitap() { Id = 5, KitapAd = "Blazor", Fiyat = 90 });
        }

        public IActionResult Index()
        {
             return View(liste);
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

        public IActionResult KitapDetay([FromRoute]int id)
        {
            //
            Kitap kitap = liste.FirstOrDefault(x => x.Id == id);//LINQ
            return View(kitap);
        }

    }
}
