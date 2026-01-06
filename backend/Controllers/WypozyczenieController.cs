using backend.Models;
using backend.Models.ViewModels;
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

        private WypozyczViewModel WyswietlViewModelWypozycz(Wypozyczenie wypozyczenie)
        {
            var klient = _context.Klienci.Find(wypozyczenie.KlientId);
            var adres = _context.Adresy.Find(klient.AdresId);
            var sprzet = _context.Sprzety.Find(wypozyczenie.SprzetId);

            var wypozycz = new WypozyczViewModel
            {

                Typ = sprzet.Typ,
                Marka = sprzet.Marka,
                Rozmiar = sprzet.Rozmiar,
                Data_zakupu = sprzet.Data_zakupu,
                Koszt_wypozyczenia = sprzet.Koszt_wypozyczenia,
                Wypozyczony = sprzet.Wypozyczony,

                Imie = klient.Imie,
                Nazwisko = klient.Nazwisko,
                Pesel = klient.Pesel,
                AdresId = klient.AdresId,

                Kod_pocztowy = adres.Kod_pocztowy,
                Miasto = adres.Miasto,
                Ulica = adres.Ulica,
                Numer_budynku = adres.Numer_budynku,
                Numer_mieszkania = adres.Numer_mieszkania,

                Data_wypoz = wypozyczenie.Data_wypoz,
                Okres_wypoz = wypozyczenie.Okres_wypoz,
                Aktywne = wypozyczenie.Aktywne
                
            };
            return wypozycz;
        }

        // GET: WypozyczenieController
        public ActionResult Index()
        {
            return View(_context.Wypozyczenia.ToList());
        }

        // GET: WypozyczenieController/Details/5
        public ActionResult Details(int id)
        {
            var wypozycz = WyswietlViewModelWypozycz(_context.Wypozyczenia.Find(id));
            return View(wypozycz);
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


        // POST: HomeController1/Wypozycz/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Zwrot(int id)
        {
            var wypozyczenie = _context.Wypozyczenia.Find(id);
            if (wypozyczenie == null)
                return NotFound();

            var sprzet = _context.Sprzety.Find(wypozyczenie.SprzetId);
            //var klient = _context.Klienci.Find(wypozyczenie.KlientId);
            //var adres = _context.Adresy.Find(klient.AdresId);
            if(sprzet == null) // || klient == null || adres == null)
                return NotFound();

            sprzet.Wypozyczony = 0;
            wypozyczenie.Aktywne = 0;
            //_context.Adresy.Remove(adres);
            //_context.Klienci.Remove(klient);
            _context.SaveChanges();
           


            return RedirectToAction(nameof(Index));

        }
    }
}
