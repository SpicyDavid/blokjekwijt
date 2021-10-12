using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlokjeKwijt.Controllers
{
    public class BlokjeCrudController : Controller
    {
        // GET: BlokjesCrud
        public ActionResult Index()
        {
            return View();
        }

        // GET: BlokjesCrud/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BlokjesCrud/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlokjesCrud/Create
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

        // GET: BlokjesCrud/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BlokjesCrud/Edit/5
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

        // GET: BlokjesCrud/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BlokjesCrud/Delete/5
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
