using Microsoft.AspNetCore.Mvc;
using MusicLibrary.Models;

namespace MusicLibrary.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index()
        {
            return View(Record.instances);
        }

        [Route("/records/new")]
        public ActionResult New()
        {
            return View();
        }


        //view should have same type (list)
        [Route("/records")]
        public ActionResult Create(string title, string artist, int year)
        {
            Record myRecord = new Record(title, artist, year);
            return View("Index", myRecord);
        }
    }
}