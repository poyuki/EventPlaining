using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EventPlaining.Models;
using EventPlaining.ViewModel;
using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.EntityFrameworkCore;

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
            List<Event> events = db.Events.Include(e=>e.Visitors).ToList();
            IndexViewModel ivm = new IndexViewModel {Events = events};
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
        public IActionResult SendSubmitEmail(NotSubmitedVisitor vi)
        {
            
            SendSubmitEmailViewModel ssevm = new SendSubmitEmailViewModel();
            try
            {
                db.NotSubmitedVisitors.Add(vi);
                db.SaveChanges();
                ssevm.Message =
                    "На указанный эелектронный почтовый ящик отправленно письмо с сылкой для подверждения регистрации на мероприятие!";
                ssevm.SuccessStatus = true;
                ssevm.Email = vi.Email;
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Админ", "Amin@mail.com"));
                message.To.Add(new MailboxAddress(String.Format("{0} {1}",vi.FirstName,vi.SecondName), vi.Email));
                message.Subject = "How you doin'?";
                
                string linkToEvent = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}";
                
                message.Body = new TextPart("plain")
                {
                    Text= $@"Приветствую вас {vi.FirstName} {vi.SecondName}!
Вый зарегестрировались на одно из меропритий в нашей системе.
Пожалуйста, подтвердите регистрацию перейдя по ссылке {linkToEvent}/Home/SubmitRegistration?id={vi.Id}"
                };
                using (var client = new SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    
                    client.Connect("smtp.gmail.com", 465, true);
                    client.Authenticate ("testmailpoyu@gmail.com", "123993pki");

                    client.Send (message);
                    client.Disconnect (true);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                ViewData["Message"] = "При регистрации на мероприятие произошла ошибка!";
                ssevm.Message ="При регистрации на мероприятие произошла ошибка!";
                ssevm.SuccessStatus = false;
            }
            
            return View(ssevm);
        }
        
        
        public IActionResult SubmitRegistration(long id)
        {
            NotSubmitedVisitor nvi=db.NotSubmitedVisitors.Find(id);
            Event ev = db.Events
                .Include(e => e.Visitors)
                .SingleOrDefault(e => e.Id == nvi.EventId);
            if (ev != null && (ev.Visitors.Count < ev.VisitorsCount||ev.VisitorsCount==0))
            {
                try
                {
                    Visitor vi=new Visitor();
                    vi.SetVIfromNvi(nvi);
                    db.Visitors.Add(vi);
                    db.NotSubmitedVisitors.Remove(nvi);
                    db.SaveChanges();
                    ViewData["Message"] = $"Регистрация прошла суспешно. Спасибо за пердстоящие участие в мераприятии: {ev.EventName}";
                }
                catch (Exception e)
                {
                    ViewData["Message"] = "При подтверждении регистрация произошел сбой, пожалуйста попробуйте позже";
                    Console.WriteLine(e);
                }
            }
            else
            {
                ViewData["Message"] = "К сожалению произошла не состыковочка и регистрация на данное мероприяте уже закрыта. Предлагаем вам зарегестрироваться ну другое мероприятие";
            }
            
            
            return View();
        }
        
        public IActionResult EventVisitors(long id)
        {
            Event ev= db.Events
                .Include(e => e.Visitors)
                .SingleOrDefault(e => e.Id == id);;
            List<NotSubmitedVisitor> nsvi= db.NotSubmitedVisitors.Where(nsvi2=>nsvi2.EventId==ev.Id).ToList();
            
            EventVisitorsViewModel rvm = new EventVisitorsViewModel
            {
                Events = ev,
                NotSubmitedVisitors = nsvi
            } ;
            return View(rvm);
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
