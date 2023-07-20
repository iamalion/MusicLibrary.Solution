using Microsoft.AspNetCore.Mvc;
using MusicLibrary.Models;

namespace MusicLibrary.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index()
        {
            Record newRecord = new Record("Add new record");
            return View(newRecord);
        }

        [Route("/titles/new")]
        public ActionResult New()
        {
            return View();
        }

        [Route("/titles")]
        public ActionResult Create(string title)
        {
            Record myRecord = new Record(title);
            return View("Index", myRecord);
        }
    }
}