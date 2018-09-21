using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace EventPlaining.Models
{
    public class EventContext :DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<NotSubmitedVisitor> NotSubmitedVisitors { get; set; }

        public EventContext(DbContextOptions opt) : base(opt)
        {
            Database.EnsureCreated();
        }
    }
}