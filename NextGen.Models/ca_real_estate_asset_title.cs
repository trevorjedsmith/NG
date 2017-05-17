namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_real_estate_asset_title
    {
        [Key]
        public int ca_real_estate_asset_title_id { get; set; }

        public int ca_real_estate_asset_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(50)]
        public string county { get; set; }

        public bool? duplicate_title_issued { get; set; }

        [StringLength(50)]
        public string folio { get; set; }

        [StringLength(50)]
        public string lot { get; set; }

        [StringLength(50)]
        public string lot_plan { get; set; }

        [StringLength(255)]
        public string other_details { get; set; }

        [StringLength(50)]
        public string parish { get; set; }

        [StringLength(50)]
        public string plan { get; set; }

        public int? plan_type { get; set; }

        [StringLength(255)]
        public string real_property_descriptor { get; set; }

        public int? tenure_type { get; set; }

        [StringLength(50)]
        public string title_reference { get; set; }

        public int? title_system_type { get; set; }

        public bool? unregistered_land { get; set; }

        public bool? unregistered_plan { get; set; }

        [StringLength(50)]
        public string volume { get; set; }

        public virtual ad_ca_plan_type ad_ca_plan_type { get; set; }

        public virtual ad_ca_tenure_type ad_ca_tenure_type { get; set; }

        public virtual ad_ca_title_system_type ad_ca_title_system_type { get; set; }

        public virtual ca_real_estate_asset ca_real_estate_asset { get; set; }
    }
}
