using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using smartstick1.Models;

namespace smartstick1.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<CallDetail> CallDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Use SQLite for simplicity
            optionsBuilder.UseSqlite("Data Source=voicecalls.db");
        }

    }
}
