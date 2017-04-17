using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Wikipages.Models;

namespace Wikipages.Controllers
{
    public class BusinessesController : Controller
    {
        private WikipagesContext db = new WikipagesContext();
        public IActionResult Index()
        {
            return View(db.Businesses.Include(Businesses => Businesses.Category).ToList());
        }
        public IActionResult Details(int id)
        {
            var thisBusiness = db.Businesses.FirstOrDefault(Businesses => Businesses.id == id);
            return View(thisBusiness);
        }
        public IActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "id", "name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Business Business)
        {
            db.Businesses.Add(Business);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var thisBusiness= db.Businesses.FirstOrDefault(Businesses => Businesses.id == id);
            ViewBag.CategoryId = new SelectList(db.Categories, "id", "name");
            return View(thisBusiness);
        }
        [HttpPost]
        public IActionResult Edit(Business Business)
        {
            db.Entry(Business).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var thisBusiness = db.Businesses.FirstOrDefault(Businesses => Businesses.id == id);
            return View(thisBusiness);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisBusiness = db.Businesses.FirstOrDefault(Businesses => Businesses.id == id);
            db.Businesses.Remove(thisBusiness);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}