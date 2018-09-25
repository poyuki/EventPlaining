using EventPlaining.Models;
using EventPlaining.Models.Session;
using Microsoft.AspNetCore.Mvc;

namespace EventPlaining.Controllers
{
    public class BaseController :Controller
    {
        public EventPlainingDBContext _db;
        public ConfigModel _MyConfigue;
        
        
        public BaseController(EventPlainingDBContext dbContext)
        {
            _db = dbContext;
            using (System.IO.StreamReader r = new System.IO.StreamReader("MyProjConfige.json"))
            {
                string json = r.ReadToEnd();
                this._MyConfigue = Newtonsoft.Json.JsonConvert.DeserializeObject<ConfigModel>(json);
            }
        }

        public UserSession GetUserInSession()
        {
           return HttpContext.Session.Get<UserSession>("userInSession");
        }

    }
    
}