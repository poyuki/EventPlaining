using System.Collections.Generic;
using EventPlaining.Models;
using EventPlaining.Models.Session;

namespace EventPlaining.ViewModel.HomeVewModels
{
    public class IndexViewModel : BaseViewModel
    {
        public IEnumerable<Event> Events { get; set; }

        public IndexViewModel(bool successSattus,string message,UserSession userInSesion, IEnumerable<Event> events) : base(successSattus,message,userInSesion)
        {
            this.Events = events;
        } 
    }
}