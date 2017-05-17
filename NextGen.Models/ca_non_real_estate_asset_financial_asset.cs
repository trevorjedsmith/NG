namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_non_real_estate_asset_financial_asset
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_non_real_estate_asset_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        public bool? transfer_ownership_to_smsf { get; set; }

        public int? financial_asset_type { get; set; }

        public virtual ad_ca_financial_asset_type ad_ca_financial_asset_type { get; set; }

        public virtual ca_non_real_estate_asset ca_non_real_estate_asset { get; set; }

        public virtual ca_non_real_estate_asset_financial_asset_account_number ca_non_real_estate_asset_financial_asset_account_number { get; set; }

        public virtual ca_non_real_estate_asset_financial_asset_account_performance ca_non_real_estate_asset_financial_asset_account_performance { get; set; }

        public virtual ca_non_real_estate_asset_financial_asset_shares ca_non_real_estate_asset_financial_asset_shares { get; set; }
    }
}
