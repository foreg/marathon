using System;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;
using Marathon.Models;

namespace Marathon
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Charity> Charities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Runner> Runners { get; set; }
        public DbSet<Sponsorship> Sponsorships { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseMySQL("server=localhost;UserId=root;Password=;database=PI;");
        }
    }
}
