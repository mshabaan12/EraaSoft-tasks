using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ahmed_mohamdy_training_1;

namespace ahmed_mohamdy_training_1.Models
{
    public class AppDbContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connections.sqlconstr);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Subject> subjects { get; set; }
        public DbSet<Grad> Grads{ get; set;}
    }
}
