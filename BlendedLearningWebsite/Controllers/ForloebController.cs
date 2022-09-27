using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlendedLearningWebsite.Controllers
{
    public class ForloebController : Controller
    {
        // GET: ForloebController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ForloebController/Details/5
        public ActionResult Details(Guid id)
        {
            var brugerId = (string)ControllerContext.RouteData.Values["brugerid"];
            var bruger = Storage.FindBruger(brugerId);
            var forløb = bruger.Forløb.FirstOrDefault(forløb => forløb.Id == id);
            return View(forløb);
        }

        // GET: ForloebController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ForloebController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ForloebController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ForloebController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ForloebController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ForloebController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
