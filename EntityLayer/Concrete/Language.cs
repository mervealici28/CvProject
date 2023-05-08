using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Language
    {
        [Key]
        public int LanguageID { get; set; }
      [StringLength(20)]
        public string LanguageName { get; set; }
        [StringLength(5)]
        public string LanguagePercent { get; set; }
        public bool LanguageStatus { get; set; }
    }

}
