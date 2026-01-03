using backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    public class WypozyczenieController : Controller
    {
        private readonly AppDbContext _context;
        public WypozyczenieController(AppDbContext context)
        {
            _context = context;
        }

        // GET: WypozyczenieController
        public ActionResult Index()
        {
            return View(_context.Wypozyczenia.ToList());
        }

        // GET: WypozyczenieController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WypozyczenieController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WypozyczenieController/Create
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

        // GET: WypozyczenieController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WypozyczenieController/Edit/5
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

        // GET: WypozyczenieController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WypozyczenieController/Delete/5
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
