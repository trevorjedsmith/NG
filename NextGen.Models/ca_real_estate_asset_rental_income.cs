namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_real_estate_asset_rental_income
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_real_estate_asset_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public bool? evidence_of_tenancy { get; set; }

        public int? frequency_short_type { get; set; }

        public decimal? ed_net_rental_amount { get; set; }

        public decimal? ed_monthly_net_rental_amount { get; set; }

        public decimal? ed_percent_for_affordability { get; set; }

        public decimal? ed_gross_rental_amount { get; set; }

        public decimal? ed_monthly_gross_rental_amount { get; set; }

        public virtual ad_ca_frequency_short_type ad_ca_frequency_short_type { get; set; }

        public virtual ca_real_estate_asset ca_real_estate_asset { get; set; }
    }
}
