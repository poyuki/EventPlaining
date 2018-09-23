using EventPlaining.Models.Session;
using EventPlaining.Models;

namespace EventPlaining.ViewModel.UserViewModels
{
    public class ProfileViewModel : BaseViewModel 
    {
        public User User { get; set; }
        
        public ProfileViewModel(bool successStatus,string message,UserSession userInSession) : base(successStatus,message,userInSession)
        {
        }
        
        public ProfileViewModel(bool successStatus,string message,UserSession userInSession,User user) : base(successStatus,message,userInSession)
        {
            this.User = user;
        }
    }
}