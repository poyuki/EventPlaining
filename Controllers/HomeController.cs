using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EventPlaining.Models;
using EventPlaining.ViewModel;
using FluentEmail.Core;
using Newtonsoft.Json.Linq;

namespace EventPlaining.Controllers
{
    public class HomeController : Controller
    {
        private EventContext db;
        public HomeController(EventContext context)
        {
            db = context;
        }
        
        public IActionResult Index()
        {
            List<Event> events = db.Events.ToList();
            IndexViewModel ivm = new IndexViewModel {Events = events};
            return View(ivm);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
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
                db.Database.EnsureCreated();
                db.Events.Add(ev);
                db.SaveChanges();
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
        
        [HttpPost]
        public IActionResult SendSubmitEmail(Visitor vi)
        {
            try
            {
                db.Visitor.Add(vi);
                db.SaveChanges();
                ViewData["Message"] = "На указанный эелектронный почтовый ящик отправленно письмо с сылкой для подверждения регистрации на мероприятие <a href='"+vi.Email+"'>Ваша почта</a>";
                
                var email = Email
                    .From("john@email.com")
                    .To("poyuki9@gmail.com", "bob")
                    .Subject("hows it going bob")
                    .Body("yo dawg, sup?")
                    .Send();

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                ViewData["Message"] = "При регистрации на мероприятие произошла ошибка!";
            }
            
            return View();
        }
        
        [HttpGet]
        public IActionResult SubmitRegistration()
        {
            
            return View();
        }
        
        [HttpGet]
        public IActionResult RegisterOnEvent(long id)
        {
            Event ev= db.Events.Find(id = id);
            
            RegisterOnEventViewModel rvm = new RegisterOnEventViewModel(ev) ;
            return View(rvm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
