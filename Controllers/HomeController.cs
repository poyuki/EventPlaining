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
            
            
            List<Event> events = _db.Events
                .Include(e=>e.EventsUsers)
                .ThenInclude(eu=>eu.User)
                .ToList();
            IndexViewModel ivm = new IndexViewModel(true,"",GetUserInSession(), events);
            
            return View(ivm);
        }

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        
        
    }
}
