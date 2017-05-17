namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_non_real_estate_asset_financial_asset_account_number
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_non_real_estate_asset_financial_asset_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(100)]
        public string account_name { get; set; }

        [StringLength(50)]
        public string account_number { get; set; }

        [StringLength(10)]
        public string bsb { get; set; }

        public int? financial_institution_type { get; set; }

        [StringLength(100)]
        public string other_fi_name { get; set; }

        public int? ed_account_type { get; set; }

        public bool? ed_core_internal_account { get; set; }

        [StringLength(5)]
        public string ed_core_account_type { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ed_maturity_date { get; set; }

        public virtual ad_ca_financial_institution_type ad_ca_financial_institution_type { get; set; }

        public virtual ad_ed_account_type ad_ed_account_type { get; set; }

        public virtual ca_non_real_estate_asset_financial_asset ca_non_real_estate_asset_financial_asset { get; set; }
    }
}
