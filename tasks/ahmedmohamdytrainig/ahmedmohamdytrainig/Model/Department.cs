using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ahmedmohamdytrainig.Model
{
    public class Department
    {
        public int Id { get; set; }
        [Required(ErrorMessage="pls enter the name") ]
        public string Name { get; set; }
        [MaxLength(5,ErrorMessage ="you canot use more")]
        public string Des { get; set; }
        public List<Student> Students { get; set; }
    }
}
