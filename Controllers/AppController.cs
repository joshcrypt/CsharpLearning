using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CsharpLearning.ViewModels;
using CsharpLearning.Services;

namespace CsharpLearning.Controllers
{
    public class AppController:Controller
    {
        private readonly IMailService _mailService;

        public AppController(IMailService mailservice)
        {
            _mailService = mailservice;
        }
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
        public IActionResult Contacts(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                //send mail
                _mailService.SendMail("joshuamangi@gmail.com", model.subject, $"From: {model.email}, Message: {model.message}");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }
            else
            {
                _mailService.SendMail("joshuamangi@gmail.com", model.subject, $"From: {model.email}, Message: {model.message}");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
                //show errors 
            }
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
