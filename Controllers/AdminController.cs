using System;
using System.Collections.Generic;
using System.Linq;
using EventPlaining.Models;
using EventPlaining.Models.Session;
using EventPlaining.ViewModel.AdminViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace EventPlaining.Controllers
{
    public class AdminController : BaseController
    {
        public AdminController(EventPlainingDBContext dbContext) : base(dbContext)
        {
        }
        
        public IActionResult AddEvent()
        {
            UserSession userInSession = GetUserInSession();
            if (userInSession.Role != "Admin")
            {
                return Redirect("~/User/Login");
            }
            AddEventViewModel aevm=new AddEventViewModel(true,"Успех",userInSession);
            
            return View(aevm);
        }
        
        [HttpPost]
        public IActionResult SubmitEvent(Event ev)
        {
            bool successStatus;
            string message;
            try
            {
                _db.Events.Add(ev);
                _db.SaveChanges();
                successStatus = true;
                message = "Событие успешно добавленно!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                successStatus = false;
                message= "При добавлении события произошла ошибка!";
            }
            SubmitEventViewModel sevm=new SubmitEventViewModel(successStatus,message,GetUserInSession());
            return View(sevm);
        }
        
        
        
        public IActionResult EventFollowedUsers(long id)
        {
            if (GetUserInSession().Role != "Admin")
            {
                return Redirect("~/Home/Index");
            }
            EventFollowedUsersViewModel efuvm;
            try
            {
                Event Event = _db.Events
                    .Include(e=>e.EventsUsers)
                    .ThenInclude(eu=>eu.User)
                    .Single(e=>e.Id==id);
                efuvm=new EventFollowedUsersViewModel(true,"Успех",GetUserInSession(),Event); 
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Redirect("~/Home/Error");
            }
            return View(efuvm);
        }
        
        [HttpPost]
        public JObject GetUserProfile(long id)
        {
            object obj;
            try
            {
                Profile profile = _db.Profiles.Find(id);
                obj = new {
                    successStatus=true,
                    FirstName=profile.FirstName,
                    SecondName=profile.SecondName,
                    Age=profile.Age,
                    PhoneNumber=profile.PhoneNumber,
                    Sec=profile.Sec,
                    About=profile.About,
                    WorkPlace=profile.WorkPlace,
                    EducPlace=profile.EducPlace, 
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                obj = new {successStatus = false};
            }
            return JObject.FromObject(obj);
        }
        [HttpPost]
        public JObject CancelEventUserFollowing(long id)
        {
            object obj;
            try
            {
                EventsUsers eventsUsers = _db.EventsUsers.Single(eu=>eu.UserId==id);
                _db.EventsUsers.Remove(eventsUsers);
                _db.SaveChanges();
                obj = new {successStatus=true,};
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                obj = new {successStatus = false};
            }
            return JObject.FromObject(obj);
        }
        
    }
}