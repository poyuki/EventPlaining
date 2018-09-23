using EventPlaining.Models.Session;

namespace EventPlaining.ViewModel.UserViewModels
{
    public class SendSubmitEmailViewModel : BaseViewModel
    {
        public string Email { get; set; }

        public SendSubmitEmailViewModel(bool successStatus, string message, UserSession userInSession, string email) 
            : base(successStatus,message,userInSession)
        {
            this.Email = email;
        }
    }
}