using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaveManBinding.Models
{
    public partial class KojModel
    {
        [Key]
        [StringLength(10)]
        public string CODE { get; set; }

        [StringLength(10)]
        public string SKOJ { get; set; }

        public int? KOJ_NENDO { get; set; }

        public int? KOJ_KBN { get; set; }

        [StringLength(20)]
        public string RYAKU { get; set; }

        [StringLength(10)]
        public string BMN_UW { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? KEIY_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? KEIY_KIN { get; set; }
    }
}
