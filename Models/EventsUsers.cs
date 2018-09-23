namespace EventPlaining.Models
{
    public class EventsUsers : BaseModel
    {
        public long EventId { get; set; }
        public Event Event { get; set; }
        
        public long UserId { get; set; }
        public User User { get; set; }
    }
}