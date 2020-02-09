using Microsoft.AspNetCore.Mvc;
using SGTubeMVC.Models;

namespace SGTubeMVC.Controllers
{
    public class SearchController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // POST: Search/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SearchViewModel busca)
        {
            try
            {                
                return RedirectToAction("Create", "Dashboard", new { texto = busca.search });
            }
            catch
            {
                return View();
            }
        }
    }
}