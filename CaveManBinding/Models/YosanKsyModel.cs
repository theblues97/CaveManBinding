using System.ComponentModel.DataAnnotations;

namespace CaveManBinding.Models
{
    public class YosanKsyModel
    {
        [Key]
        [StringLength(10)]
        public string YOSAN_GNO { get; set; }

        [StringLength(40)]
        public string NAME { get; set; }

        public int? KAISOU_KBN { get; set; }

        public int? KSY_SYO { get; set; }
 
        public int? KAISOU1 { get; set; }

        public int? KAISOU2 { get; set; }

        public int? KAISOU3 { get; set; }

        public int? KAISOU4 { get; set; }

        public int? KAISOU5 { get; set; }
    }
}