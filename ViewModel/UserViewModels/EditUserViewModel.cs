using EventPlaining.Models;
using EventPlaining.Models.Session;

namespace EventPlaining.ViewModel.UserViewModels
{
    public class EditUserViewModel: ProfileViewModel
    {
        public EditUserViewModel(bool successStatus, string message, UserSession userInSession) : base(successStatus, message, userInSession)
        {
        }

        public EditUserViewModel(bool successStatus, string message, UserSession userInSession, User user) : base(successStatus, message, userInSession, user)
        {
        }
    }
}