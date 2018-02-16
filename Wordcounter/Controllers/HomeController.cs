using Microsoft.AspNetCore.Mvc;
using Wordcounter.Models;
using System.Collections.Generic;

namespace Wordcounter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
