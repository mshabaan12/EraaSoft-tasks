using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ahmedmohamdytrainig.Model
{
    public class AppDbContext : DbContext

    { protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connections.sqlConstr);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Grad> Grads { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<StudentBook> StudentBooks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<Department>().Property(x => x.Des).IsRequired(false);

        }


    }
}
