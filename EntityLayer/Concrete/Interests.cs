using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Interests
    {
        [Key]
        public int InterestsID { get; set; }
     [StringLength(50)]
        public string InterestsName { get; set; }
        [StringLength(50)]
        public string InterestsPicture { get; set; }
        public bool InterestsStatus { get; set; }
    }

}
