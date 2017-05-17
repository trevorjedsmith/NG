namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_real_estate_asset_estimated_value
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_real_estate_asset_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public int? estimate_basis_real_estate_asset_type { get; set; }

        public decimal? estimated_cgt_liability { get; set; }

        public decimal? estimated_value { get; set; }

        public decimal? ed_percent_for_affordability { get; set; }

        public decimal? ed_core_value { get; set; }

        public virtual ad_ca_estimate_basis_real_estate_asset_type ad_ca_estimate_basis_real_estate_asset_type { get; set; }

        public virtual ca_real_estate_asset ca_real_estate_asset { get; set; }
    }
}
