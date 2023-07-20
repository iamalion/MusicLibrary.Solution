using Microsoft.AspNetCore.Mvc;
using MusicLibrary.Models;
using System.Collections.Generic;

namespace MusicLibrary.Controllers
{
    public class CollectionsController : Controller
    {
        [Route("/collections/new")]
        public ActionResult New()
        {
            return View();
        }
        
        //view should have same type (list)
        [Route("/collections")]
        public ActionResult Create(string name)
        {
            Collection myCollection = new Collection(name);
            return View("Index", myCollection);
        }
    }

}