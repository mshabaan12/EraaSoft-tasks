using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace challeangeLec18.classes
{
        [PrimaryKey(nameof(Position), nameof(Name) )]
    public class Employee
    { 

        public int Id { get; set; }
        [Column(TypeName ="varchar(100)")] //the first  way


        [MaxLength(100)] //the second way
        [Unicode(false)] 

        public string Position { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Employee(int id, string name, string position, decimal salary)
        {
            Id = id;
            Name = name;
            Position = position;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Position: {Position}, Salary: {Salary:C}";
        }
    }
}
