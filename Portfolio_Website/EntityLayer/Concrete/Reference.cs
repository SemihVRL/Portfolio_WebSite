using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Reference
    {
        [Key]
        public int ReferenceID { get; set; }
        public int Name { get; set; }
        public int Company { get; set; }
        public int Comment { get; set; }
    }
}
