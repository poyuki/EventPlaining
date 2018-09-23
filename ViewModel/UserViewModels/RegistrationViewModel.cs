using EventPlaining.Models.Session;

namespace EventPlaining.ViewModel.UserViewModels
{
    public class RegistrationViewModel : BaseViewModel
    {
        public RegistrationViewModel(bool successStatus,string message,UserSession userInSession) : base(successStatus,message,userInSession)
        {
        }
    }
}