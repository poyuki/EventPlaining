namespace EventPlaining.Models.Session
{
    public class UserSession
    {
        public long Id { get; set; }
        public bool LogedIn { get; set; }
        public string Role { get; set; }

        public UserSession()
        {
            this.LogedIn = false;
            this.Role = "Default";
        }

        public UserSession(User user)
        {
            this.Id = user.Id;
            this.LogedIn = true;
            this.Role = user.Role;
        }
    }
}