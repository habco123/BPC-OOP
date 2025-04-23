using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace cv11.EFCore
{
    internal class Vyukacontext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\vyuka.mdf;Integrated Security=True;Connection Timeout=30");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
