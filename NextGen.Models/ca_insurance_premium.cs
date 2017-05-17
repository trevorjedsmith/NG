namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_insurance_premium
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_insurance_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public decimal? amount { get; set; }

        public int? frequency_short_type { get; set; }

        public virtual ad_ca_frequency_short_type ad_ca_frequency_short_type { get; set; }

        public virtual ca_insurance ca_insurance { get; set; }
    }
}
