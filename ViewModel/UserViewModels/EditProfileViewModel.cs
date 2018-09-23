using EventPlaining.Models;
using EventPlaining.Models.Session;

namespace EventPlaining.ViewModel.UserViewModels
{
    public class EditProfileViewModel : BaseViewModel
    {
        public Profile Profile { get; set; }
        
        public EditProfileViewModel(bool successStatus, string message, UserSession userInSession) : base(successStatus, message, userInSession)
        {
        }

        public EditProfileViewModel(bool successStatus, string message, UserSession userInSession, Profile profile) : base(successStatus, message, userInSession)
        {
            this.Profile = profile;
        }
    }
}