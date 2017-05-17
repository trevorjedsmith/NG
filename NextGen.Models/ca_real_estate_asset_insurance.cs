namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_real_estate_asset_insurance
    {
        [Key]
        public int ca_real_estate_asset_insurance_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public int ca_real_estate_asset_id { get; set; }

        [StringLength(36)]
        public string ed_real_estate_asset_external_guid { get; set; }

        public int ca_insurance_id { get; set; }

        [StringLength(36)]
        public string ed_insurance_external_guid { get; set; }

        public virtual ca_insurance ca_insurance { get; set; }

        public virtual ca_real_estate_asset ca_real_estate_asset { get; set; }
    }
}
