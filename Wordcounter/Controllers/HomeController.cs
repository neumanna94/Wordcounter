using Microsoft.AspNetCore.Mvc;
using Wordcounter.Models;
using System;

namespace Wordcounter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost("/")]
        public ActionResult IndexPost()
        {
            string word = Request.Form["word"];
            string sentence = Request.Form["sentence"];

            RepeatCounter one = new RepeatCounter(word, sentence);
            //This if-else block is to deal with empty input.
            if(word.Length > 0 && sentence.Length > 0){
                one.WordCount();
            } else {
            }
            return View("Index", one);
        }
    }
}
