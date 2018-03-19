using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CsharpLearning.Controllers
{
    public class AppController:Controller
    {
        public IActionResult Index()
        {
            //throw new InvalidOperationException("Bad things happened");
            return View();
        }
        [HttpGet("contacts")]
        public IActionResult Contacts()
        {
            ViewBag.Title = "Contact US";
            //throw new InvalidOperationException("Bad things happened");
            return View();
        }
        [HttpPost("contacts")]
        public IActionResult Contacts(object model)
        {
            ViewBag.Title = "Contact Us";
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Title = "About US";
            return View();
        }
    }
}
