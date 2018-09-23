using EventPlaining.Models.Session;

namespace EventPlaining.ViewModel.UserViewModels
{
    public class SubmitRegistrationViewModel : BaseViewModel
    {
        public SubmitRegistrationViewModel(string message,bool successStatus,UserSession userInSession) : base(successStatus,message,userInSession)
        {
        }
    }
}