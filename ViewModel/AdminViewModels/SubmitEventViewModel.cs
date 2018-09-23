using EventPlaining.Models.Session;

namespace EventPlaining.ViewModel.AdminViewModels
{
    public class SubmitEventViewModel : BaseViewModel
    {
        public SubmitEventViewModel(bool successStatus, string message, UserSession userInSession) : base(successStatus, message, userInSession)
        {
        }
    }
}