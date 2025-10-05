using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challeangeLec18.classes
{
    public class specialty
    { 
        public int Id { get; set; }
        public int OfficerId { get; set; }
       
        public List<officer> Officers { get; set; } 


    }
}
