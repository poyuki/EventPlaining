using EventPlaining.Models.Session;
using Microsoft.AspNetCore.Http;

namespace EventPlaining.ViewModel
{
    public class BaseViewModel
    {
        public bool SuccessStatus { get; set; }
        public string Message { get; set; }
        public UserSession UserInSession { get; set; }

        public BaseViewModel(bool successStatus,string message ,UserSession userInSession)
        {
            this.UserInSession = userInSession;
            this.Message = message;
            this.SuccessStatus = successStatus;
        }
    }
    
    
}