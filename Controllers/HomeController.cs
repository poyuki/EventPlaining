using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EventPlaining.Models;
using EventPlaining.Models.Session;
using EventPlaining.ViewModel;
using EventPlaining.ViewModel.HomeVewModels;
using EventPlaining.ViewModel.UserViewModels;
using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace EventPlaining.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(EventPlainingDBContext dbContext) : base(dbContext)
        {
        }
        
        public IActionResult Index()
        {
            
            
            List<Event> events = _db.Events.ToList();
            IndexViewModel ivm = new IndexViewModel(true,"",GetUserInSession(), events);
            
            return View(ivm);
        }

        public IActionResult AddEvent()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult SubmitEvent(Event ev)
        {
            
            try
            {
                _db.Events.Add(ev);
                _db.SaveChanges();
                ViewData["Message"] = "Событие успешно добавленно!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                ViewData["Message"] = "При добавлении события произошла ошибка!";
            }
            
            return View();
        }
        
        
        
        public IActionResult EventVisitors(long id)
        {
            
            return View();
        }
        
        
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        
        
    }
}
