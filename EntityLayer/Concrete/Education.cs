using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Education
    {
        [Key]
        public int EducationID { get; set; }
      [StringLength(45)]
        public string EducationName { get; set; }
        [StringLength(12)]
        public string EducationYear { get; set; }
        [StringLength(70)]
        public string EducationSection { get; set; }
        [StringLength(12)]
        public string EducationDegree { get; set; }
        public bool EducationStatus { get; set; }
    }

}
