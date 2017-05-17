namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_non_real_estate_asset_financial_asset_account_performance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_non_real_estate_asset_financial_asset_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public short? ed_no_of_overdraws_ltd { get; set; }

        public short? ed_days_overdrawn_ytd { get; set; }

        public virtual ca_non_real_estate_asset_financial_asset ca_non_real_estate_asset_financial_asset { get; set; }
    }
}
