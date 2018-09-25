using System.Collections.Generic;
using EventPlaining.Models;
using EventPlaining.Models.Session;

namespace EventPlaining.ViewModel.AdminViewModels
{
     
    public class UsersListViewModel :BaseViewModel
    {
        public List<User> Users { get; set; }
        
        public UsersListViewModel(bool successStatus, string message, UserSession userInSession) : base(successStatus, message, userInSession)
        {
        }
        public UsersListViewModel(bool successStatus, string message, UserSession userInSession,List<User> users) : base(successStatus, message, userInSession)
        {
            this.Users = users;
        }
        
    }
}