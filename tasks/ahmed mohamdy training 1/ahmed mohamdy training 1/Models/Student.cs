using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using ahmed_mohamdy_training_1.Models;

namespace ahmed_mohamdy_training_1.Models
{
    public class Student
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public DateTime Birthdate { get; set; }
        //relation with Grad one to one 
        public Grad Grad { get; set; }
        //relation with Department many to one
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
