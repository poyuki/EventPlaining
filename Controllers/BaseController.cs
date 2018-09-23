using EventPlaining.Models;
using EventPlaining.Models.Session;
using Microsoft.AspNetCore.Mvc;

namespace EventPlaining.Controllers
{
    public class BaseController :Controller
    {
        public EventPlainingDBContext _db;
        
        
        public BaseController(EventPlainingDBContext dbContext)
        {
            _db = dbContext;
        }

        public UserSession GetUserInSession()
        {
           return HttpContext.Session.Get<UserSession>("userInSession");
        }

    }
    
}