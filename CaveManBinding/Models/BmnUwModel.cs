using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaveManBinding.Models
{
    public class BmnUwModel
    {
        [Key]
        [StringLength(10)]
        public string CODE { get; set; }

        [StringLength(20)]
        public string RYAKU { get; set; }

        [StringLength(10)]
        public string S_BMN_UW { get; set; }

        public int? KAISOU { get; set; }

        public int? OUT_LEVEL { get; set; }

        [StringLength(10)]
        public string SUM_BMN_UW { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? START_DATE { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? END_DATE { get; set; }
    }
}
