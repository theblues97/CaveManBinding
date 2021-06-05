using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace DbConnection
{
    public partial class M_KOJ
    {
        [Key]
        [StringLength(10)]
        public string CODE { get; set; }

        [StringLength(10)]
        public string SKOJ { get; set; }

        [StringLength(40)]
        public string NAME { get; set; }

        [StringLength(20)]
        public string KANA { get; set; }

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
