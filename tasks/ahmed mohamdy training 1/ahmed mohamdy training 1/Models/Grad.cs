using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ahmed_mohamdy_training_1.Models
{
    public class  Grad
    { 
        public int Id { get; set; }
        public decimal physics { get; set; }
        public decimal chemistry { get; set; }
        public decimal programing { get; set; }
        //relation with Student one to one
        [ForeignKey ("Student")]
        public int studentId { get; set; }
        public Student Student { get; set; }


    }
}
