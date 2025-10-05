using Microsoft.EntityFrameworkCore;
using ROM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ROM.Models;

namespace ROM.data_access
{
    public class ApplicationDpContext: DbContext 
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }  
        public DbSet <Department > Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        
        protected  override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;initial catalog=teEF-proj20;Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;" +
                "Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
