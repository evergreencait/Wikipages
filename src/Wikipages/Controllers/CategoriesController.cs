using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wikipages.Models;
using Microsoft.EntityFrameworkCore;
namespace Wikipages.Controllers
{
    public class CategoriesController : Controller
    {
        private WikipagesContext db = new WikipagesContext();
        public IActionResult Index()
        {
            return View(db.Categories.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisCategory = db.Categories.FirstOrDefault(categories => categories.id == id);
            return View(thisCategory);
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category currentCategory)
        {
            db.Categories.Add(currentCategory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}