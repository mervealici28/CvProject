using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Experience
    {
        [Key]
        public int ExperienceID { get; set; }
        [StringLength(100)]
        public string ExperienceName { get; set; }
        [StringLength(15)]
        public string ExperienceYear { get; set; }
        [StringLength(500)]
        public string ExperienceDescription { get; set; }
        [StringLength(70)]
        public string ExperienceTask { get; set; }
        public bool ExperienceStatus { get; set; }
    }

}
