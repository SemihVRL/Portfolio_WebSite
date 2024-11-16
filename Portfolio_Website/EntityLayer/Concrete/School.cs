using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class School
    {
        [Key]
        public int SchoolID { get; set; }
        public string Name { get; set; }
      
        public string Date { get; set; }
   
        public string Section { get; set; }
        public string Image { get; set; }
    }
}
