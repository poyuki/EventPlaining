namespace EventPlaining.Models
{
    public class EventsUsers
    {
        public long EventId { get; set; }
        public Event Event { get; set; }
        
        public long UserId { get; set; }
        public User User { get; set; }

        public EventsUsers(long eventId, long userId)
        {
            this.EventId = eventId;
            this.UserId=userId;
        }
    }
}