using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlaining.Models
{
    public class Visitor
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string AboutInfo { get; set; }
        public long EventId { get; set; }
        [ForeignKey("EventId")]
        public Event Event{ get; set; }


        public void SetVIfromNvi(NotSubmitedVisitor nvi)
        {

            this.FirstName = nvi.FirstName;
            this.SecondName = nvi.SecondName;
            this.Age = nvi.Age;
            this.Email= nvi.Email;
            this.AboutInfo= nvi.AboutInfo;
            this.EventId = nvi.EventId;
        }
    }
}