using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Wikipages.Models;

namespace Wikipages.Controllers
{
    public class CategoriesController : Controller
    {
        private WikipagesContext db = new WikipagesContext();
        public IActionResult Index()
        {
            return View(db.Categories.ToList());
        }
    }
}