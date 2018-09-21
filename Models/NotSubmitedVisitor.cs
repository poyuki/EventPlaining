namespace EventPlaining.Models
{
    public class NotSubmitedVisitor
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string AboutInfo { get; set; }
        public long EventId { get; set; }
    }
}