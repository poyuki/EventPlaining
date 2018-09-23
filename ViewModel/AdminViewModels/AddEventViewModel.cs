using EventPlaining.Models.Session;

namespace EventPlaining.ViewModel.AdminViewModels
{
    public class AddEventViewModel : BaseViewModel
    {
        public AddEventViewModel(bool successStatus, string message, UserSession userInSession) : base(successStatus, message, userInSession)
        {
        }
    }
}