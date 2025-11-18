using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ahmed_mohamdy_training_1.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ahmed_mohamdy_training_1.Models
{
    public class Department
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        //relation with Student one to many
        public ICollection<Student> Students { get; set; } 
        //public List<Student> Students { get; set; } 

    }
}
