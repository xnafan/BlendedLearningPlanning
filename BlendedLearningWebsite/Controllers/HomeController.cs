using BlendedLearningWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BlendedLearningWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index([FromRoute] string brugerid)
        {

            var bruger = Storage.FindBruger(brugerid);
            if (bruger != null )
            {
                return View(Storage.Brugere[brugerid]);
            }
            return View();
        }

        public IActionResult Create()
        {
            var bruger = Storage.CreateNewBruger();
            bruger.Forløb.Add(new Models.Domain.Forløb("Mit forløb"));
            return RedirectToAction("Index", new { brugerid=bruger.Id });
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