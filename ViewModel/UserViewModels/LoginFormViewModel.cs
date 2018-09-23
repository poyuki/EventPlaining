using EventPlaining.Models.Session;

namespace EventPlaining.ViewModel.UserViewModels
{
    public class LoginFormViewModel : BaseViewModel
    {

        public LoginFormViewModel(bool successStatus,string message, UserSession userInSession) : base(successStatus,message,userInSession)
        {
            
        }
    }
}