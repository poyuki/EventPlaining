using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace EventPlaining.Models
{
    public class EventContext :DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Visitor> Visitor { get; set; }

        public EventContext(DbContextOptions opt) : base(opt)
        {
            Database.EnsureCreated();
        }
        
    }
}