using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Reference
    {
        [Key]
        public int ReferenceID { get; set; }
      [StringLength(35)]
        public string ReferenceName { get; set; }
        [StringLength(15)]
        public string ReferencePhone { get; set; }
        [StringLength(30)]
        public string ReferenceTask { get; set; }
        [StringLength(35)]
        public string ReferenceMail{ get; set; }
        public bool ReferenceStatus { get; set; }
    }

}
