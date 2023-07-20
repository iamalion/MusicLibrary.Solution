// using Microsoft.AspNetCore.Mvc;
// using MusicLibrary.Models;
// using System.Collections.Generic;

// namespace MusicLibrary.Controllers
// {
//     public class RecordsController : Controller
//     {
//         [Route("/records/new")]
//         public ActionResult New()
//         {
//             return View();
//         }
        
//         //view should have same type (list)
//         [Route("/records")]
//         public ActionResult Create(string title, string artist, int year)
//         {
//             Record myRecord = new Record(title, artist, year);
//             return View("Index", myRecord);
//         }
//     }

// }