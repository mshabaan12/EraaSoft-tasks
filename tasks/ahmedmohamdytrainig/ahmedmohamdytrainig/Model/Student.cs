using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ahmedmohamdytrainig.Model
{
    public class Student
    { public int Id { get; set; }
      public string Name { get; set; }
      public int Age { get; set; }
      public Grad Grad { get; set; }
        public int DepartmentID { get; set; }
        public Department Department { get; set; }
        public List<StudentBook> StudentBooks { get; set; }

    }
}
