using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EventPlaining.Models
{
    public class Profile:BaseModel
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public string About { get; set; }
        public string Sec { get; set; }
        public string WorkPlace { get; set; }
        public string EducPlace { get; set; }
        public string PhoneNumber { get; set; }
     }
}