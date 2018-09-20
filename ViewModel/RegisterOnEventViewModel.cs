using EventPlaining.Models;

namespace EventPlaining.ViewModel
{
    public class RegisterOnEventViewModel
    {
        public Event Event { get; set; }

        public RegisterOnEventViewModel(Event ev)
        {
            this.Event = ev;
        }
    }
}