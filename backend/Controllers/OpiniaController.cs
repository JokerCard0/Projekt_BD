using backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace backend.Controllers
{
    public class OpiniaController : Controller
    {

        private readonly AppDbContext _context;
        public OpiniaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: OpiniaController
        public ActionResult Index()
        {
            return View(_context.Opinie.ToList());
        }

        // GET: OpiniaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OpiniaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OpiniaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Opinia opinia)
        {
            try
            {
                _context.Opinie.Add(opinia);
                _context.SaveChanges();
                return RedirectToAction("Index","Sprzet");

            }
            catch
            {
                return View();
            }
        }

        // GET: OpiniaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OpiniaController/Edit/5
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

        // GET: OpiniaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OpiniaController/Delete/5
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
