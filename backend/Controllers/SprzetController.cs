using backend.Models;
using backend.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    public class SprzetController : Controller
    {

        private readonly AppDbContext _context;
        public SprzetController(AppDbContext context)
        {
            _context = context;
        }


        // GET: HomeController1
        public ActionResult Index(Rodzaje? typ)
        {
            var sprzety = _context.Sprzety.AsQueryable();
            if (typ.HasValue)
                sprzety = sprzety.Where(x => x.Typ == typ.Value);
            
            return View(sprzety.ToList());
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            var sprzet = _context.Sprzety.Find(id);
            if (sprzet == null)
                return NotFound();
            return View(sprzet);
        }


        // GET: HomeController1/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
            
        }

        // POST: HomeController1/Create
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Sprzet sprzet)
        {
            try
            {
                _context.Sprzety.Add(sprzet);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        [Authorize]
        public ActionResult Edit(int id)
        {
            var sprzet = _context.Sprzety.Find(id);
            if (sprzet == null)
                return NotFound();
            return View(sprzet);
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit(int id, Sprzet sprzet)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(sprzet);
                var existing = _context.Sprzety.FirstOrDefault(x => x.Id == id);
                if (existing == null) 
                    return NotFound();
                existing.Typ = sprzet.Typ;
                existing.Marka = sprzet.Marka;
                existing.Rozmiar = sprzet.Rozmiar;
                existing.Data_zakupu = sprzet.Data_zakupu; 
                existing.Koszt_wypozyczenia = sprzet.Koszt_wypozyczenia;
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        [Authorize]
        public ActionResult Delete(int id)
        {
            var sprzet = _context.Sprzety.Find(id);
            if (sprzet == null)
                return NotFound();
            return View(sprzet);
        }

        // POST: HomeController1/Delete/5
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Sprzet sprzet)
        {
            try
            {
                _context.Sprzety.Remove(sprzet);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Wypozycz/5
        [HttpGet]
        public ActionResult Wypozycz(int id)
        {
            var sprzet = _context.Sprzety.Find(id);
            if (sprzet == null)
                return NotFound();
            var model = new WypozyczViewModel { SprzetId = id };

            return View(model);
        }

        // POST: HomeController1/Wypozycz/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Wypozycz(WypozyczViewModel wypozycz)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(wypozycz);
                
                
                var adres = new Adres
                {
                    Kod_pocztowy = wypozycz.Kod_pocztowy,
                    Miasto = wypozycz.Miasto,
                    Ulica = wypozycz.Ulica,
                    Numer_budynku = wypozycz.Numer_budynku,
                    Numer_mieszkania = wypozycz.Numer_mieszkania
                };
                _context.Adresy.Add(adres);
                _context.SaveChanges();


                var klient = new Klient
                {
                    Imie = wypozycz.Imie,
                    Nazwisko = wypozycz.Nazwisko,
                    Pesel = wypozycz.Pesel,
                    AdresId = adres.Id,
                };
                _context.Klienci.Add(klient);
                _context.SaveChanges();


                var wypozyczenie = new Wypozyczenie
                {
                    KlientId = klient.Id,
                    SprzetId = wypozycz.SprzetId,
                    Data_wypoz = wypozycz.Data_wypoz,
                    Okres_wypoz = wypozycz.Okres_wypoz
                };
                _context.Wypozyczenia.Add(wypozyczenie);
                _context.SaveChanges();


                var sprzet = _context.Sprzety.Find(wypozycz.SprzetId);
                sprzet.Wypozyczony = 1;
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
