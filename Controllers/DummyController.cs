using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TravelManagement.Controllers
{
    public class DummyController : Controller
    {
        // GET: Dummy
        public ActionResult Index()
        {
            return View();
        }

        // GET: Dummy/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dummy/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dummy/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Dummy/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dummy/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Dummy/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dummy/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}