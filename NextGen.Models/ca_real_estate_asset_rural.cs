namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_real_estate_asset_rural
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_real_estate_asset_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public short? number_of_buildings { get; set; }

        public int? rural_type { get; set; }

        public int? rural_usage_type { get; set; }

        public virtual ad_ca_rural_type ad_ca_rural_type { get; set; }

        public virtual ad_ca_rural_usage_type ad_ca_rural_usage_type { get; set; }

        public virtual ca_real_estate_asset ca_real_estate_asset { get; set; }
    }
}
