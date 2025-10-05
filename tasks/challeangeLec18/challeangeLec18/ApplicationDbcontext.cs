using challeangeLec18.classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Intrinsics.Arm;

namespace challeangeLec18
{
    public class ApplicationDbContext : DbContext

    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<officer> Officers { get; set; }
        public DbSet<specialty> Specialties { get; set; }  
        public DbSet<cours> courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enroll> Enrolls { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EmployeeDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .HasColumnType("varchar(100)" //third way


            );
            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .HasMaxLength(100) //fourth way
                .IsUnicode(false);
            modelBuilder.Entity<Employee>()
                .HasKey(e => new { e.Position, e.Name }); //composite key
        }
    }
}
