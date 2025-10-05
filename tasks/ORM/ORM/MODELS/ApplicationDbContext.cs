using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ORM.MODELS.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ORM.MODELS
{
    public class ApplicationDbContext : DbContext

    {
        public DbSet<Category> categories { get; set; }
        
        public DbSet<Product> products { get; set; }
        public DbSet<Person> persons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>()

                .Property("Name")
                .HasColumnType("varchar(50)");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;initial catalog=EFProjct520;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;" +
                "Application Intent=ReadWrite;Multi Subnet Failover=False");
                }

    }
}
