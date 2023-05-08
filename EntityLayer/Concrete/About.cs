using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        [StringLength(35)]
        public string Name { get; set; }
        [StringLength(35)]
        public string Mail { get; set; }
        [StringLength(15)]
        public string Phone { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        [StringLength(15)]
        public string Location { get; set; }
        [StringLength(500)]
        public string Description { get; set; }

        public bool CvStatus { get; set; }
        
    }
}
