using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Skills
    {
        [Key]
        public int SkillsID { get; set; }
   [StringLength(15)]
        public string SkillsName { get; set; }
        [StringLength(3)]
        public string SkillsPercent { get; set; }
        public bool SkillsStatus { get; set; }
    }

}
