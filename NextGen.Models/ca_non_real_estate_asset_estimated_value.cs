namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_non_real_estate_asset_estimated_value
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_non_real_estate_asset_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public decimal? balloon_rv_amount { get; set; }

        public int? balloon_rv_input_pattern_type { get; set; }

        public decimal? balloon_rv_percent { get; set; }

        public int? estimate_basis_non_real_estate_asset_type { get; set; }

        public decimal? estimated_cgt_liability { get; set; }

        public decimal? minimum_residual_value { get; set; }

        public int? tax_depreciation_method_type { get; set; }

        public decimal? tax_depreciation_rate { get; set; }

        public decimal? estimated_value { get; set; }

        public decimal? ed_percent_for_affordability { get; set; }

        public decimal? ed_core_value { get; set; }

        public virtual ad_ca_balloon_rv_input_pattern_type ad_ca_balloon_rv_input_pattern_type { get; set; }

        public virtual ad_ca_estimate_basis_non_real_estate_asset_type ad_ca_estimate_basis_non_real_estate_asset_type { get; set; }

        public virtual ad_ca_tax_depreciation_method_type ad_ca_tax_depreciation_method_type { get; set; }

        public virtual ca_non_real_estate_asset ca_non_real_estate_asset { get; set; }
    }
}
