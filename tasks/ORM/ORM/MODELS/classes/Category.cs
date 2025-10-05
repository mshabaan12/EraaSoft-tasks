using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.MODELS.classes
{
    public class Category
    {

        [Key]
        public int ID {  get; set; }

        //[Column("categoryname")]
        [Column (TypeName = "varchar(50)" )]

        public string Name { get; set; }

        [Column(Order =2 ) ]
        public string Description { get; set; } 
         
        public bool status { get; set; }

    }
}
