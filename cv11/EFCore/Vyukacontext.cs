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
        public DbSet<Predmet> Predmety { get; set; }
        public DbSet<StudentPredmet> StudentPredmet { get; set; }
        public DbSet<Hodnoceni> Hodnotenie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\vyuka.mdf;Integrated Security=True;Connection Timeout=30");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentPredmet>()
            .HasKey(sp => new { sp.StudentId, sp.Zkratka });

            modelBuilder.Entity<Hodnoceni>()
                .HasKey(h => new { h.StudentId, h.ZkratkaPredmet });

            modelBuilder.Entity<StudentPredmet>()
                .HasOne(sp => sp.Student)
                .WithMany(s => s.StudentPredmety)
                .HasForeignKey(sp => sp.StudentId);

            modelBuilder.Entity<StudentPredmet>()
                .HasOne(sp => sp.Predmet)
                .WithMany(p => p.StudentPredmety)
                .HasForeignKey(sp => sp.Zkratka);

            modelBuilder.Entity<Hodnoceni>()
                .HasOne(h => h.Student)
                .WithMany(s => s.Hodnoceni)
                .HasForeignKey(h => h.StudentId);

            modelBuilder.Entity<Hodnoceni>()
                .HasOne(h => h.Predmet)
                .WithMany(p => p.Hodnoceni)
                .HasForeignKey(h => h.ZkratkaPredmet);
        }
    }
}
