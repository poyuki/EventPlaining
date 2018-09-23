using System.Collections.Generic;
using EventPlaining.Models;
using EventPlaining.Models.Session;

namespace EventPlaining.ViewModel.AdminViewModels
{
    public class EventFollowedUsersViewModel : BaseViewModel
    {
        public Event Event { get; set; }
        
        public EventFollowedUsersViewModel(bool successStatus, string message, UserSession userInSession,Event Event) : base(successStatus, message, userInSession)
        {
            this.Event = Event;
        }
    }
}