namespace EventPlaining.Models
{
    public class NotSubmitedUser: BaseModel
    {
        public string LogInName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public NotSubmitedUser()
        {
            this.Role = "User";
        }
    }
    
    
}    