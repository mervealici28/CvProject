using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{

    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
       [StringLength(35)]
        public string ContactUserName { get; set; }
        [StringLength(35)]
        public string ContactMail { get; set; }
        [StringLength(500)]
        public string ContactMessage { get; set; }
        public string ContactIp { get; set; }
        public DateTime ContactDate { get; set; }
 
        public bool ContactStatus { get; set; }

    }

}
