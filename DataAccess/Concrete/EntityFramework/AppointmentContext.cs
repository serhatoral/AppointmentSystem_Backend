using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
   public class AppointmentContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AppointmentDatabase;Trusted_Connection=true");
        }


        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Consultant> Consultant { get; set; }       
        public DbSet<User> User { get; set; }
    }
}
