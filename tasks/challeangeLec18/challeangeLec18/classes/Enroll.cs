using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challeangeLec18.classes
{
    [PrimaryKey(nameof(StudentId),nameof(coursId))]
    public class Enroll
    { 
        
        public int StudentId { get; set; }
        public Student student { get; set; }
        public int coursId { get; set; }
        public cours cours { get; set; }
    }
}
