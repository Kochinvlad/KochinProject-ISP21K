using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KochinProject_ISP21K.Models;

namespace KochinProject_ISP21K.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Card> Cards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-R71F0DV\\SQLEXPRESS; Database=qwe; Trusted_Connection=true; TrustServerCertificate=true");
        }
    }
}

