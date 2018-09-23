using System;
using EventPlaining.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventPlaining.Controllers
{
    public class AdminController : BaseController
    {
        public AdminController(EventPlainingDBContext dbContext) : base(dbContext)
        {
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
    }
}