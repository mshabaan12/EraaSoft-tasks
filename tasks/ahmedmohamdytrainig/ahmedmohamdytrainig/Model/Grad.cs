using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ahmedmohamdytrainig.Model
{
    public class Grad
    { 
        public int Id { get; set; }
        public decimal chemistry { get; set; }
        public decimal math { get; set; }
        public decimal physics { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }


    }
}
