using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlaining.Models
{
    public class User : BaseModel
    {
        public string LogInName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        [ForeignKey("Profile")]
        public long ProfileId { get; set; }

        public List<EventsUsers> EventsUsers { get; set; }
        public Profile Profile { get; set; }

        public User()
        {
            this.Profile=new Profile();
            this.EventsUsers=new List<EventsUsers>();
        }

        public void SubmitUser(NotSubmitedUser nsu)
        {
            this.LogInName = nsu.LogInName;
            this.Password = nsu.Password;
            this.Email = nsu.Email;
            this.Role = nsu.Role;
        }
    }
}