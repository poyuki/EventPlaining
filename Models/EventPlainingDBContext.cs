﻿using System.Linq;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace EventPlaining.Models
{
    public class EventPlainingDBContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<EventsUsers> EventsUsers { get; set; }
        public DbSet<NotSubmitedUser> NotSubmitedUsers { get; set; }
        
        public EventPlainingDBContext(DbContextOptions opt) : base(opt)
        {
            ConfigModel myConfig;
            using (System.IO.StreamReader r = new System.IO.StreamReader("MyProjConfige.json"))
            {
                string json = r.ReadToEnd();
                myConfig = Newtonsoft.Json.JsonConvert.DeserializeObject<ConfigModel>(json);
            }
            Database.EnsureCreated();
            if (!this.Users.Any(u => u.Role == "Admin"))
            {
                User admin = new User
                {
                    LogInName = myConfig.dbSetings.appAdmin.login,
                    Password = myConfig.dbSetings.appAdmin.password,
                    Role = "Admin"
                };
                this.Users.Add(admin);
                this.SaveChanges();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventsUsers>()
                .HasKey(t=>new {t.EventId,t.UserId});

            modelBuilder.Entity<EventsUsers>()
                .HasOne(eu => eu.Event)
                .WithMany(e => e.EventsUsers)
                .HasForeignKey(eu => eu.EventId);
            
            modelBuilder.Entity<EventsUsers>()
                .HasOne(eu => eu.User)
                .WithMany(u => u.EventsUsers)
                .HasForeignKey(eu => eu.UserId);
            
        } 
    }
}