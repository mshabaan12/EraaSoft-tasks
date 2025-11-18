using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ahmedmohamdytrainig.Model
{
    public class StudentBook
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student student { get; set; }
        public int BookId { get; set; }
        public Book book { get; set; }
    }
}
