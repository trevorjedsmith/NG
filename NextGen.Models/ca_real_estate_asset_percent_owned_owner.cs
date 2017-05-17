namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_real_estate_asset_percent_owned_owner
    {
        [Key]
        public int ca_real_estate_asset_percent_owned_owner_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public int ca_real_estate_asset_id { get; set; }

        [StringLength(36)]
        public string ed_real_estate_asset_external_guid { get; set; }

        public int ca_person_applicant_id { get; set; }

        [StringLength(36)]
        public string ed_person_applicant_external_guid { get; set; }

        public decimal? percent_owned { get; set; }

        public virtual ca_person_applicant ca_person_applicant { get; set; }

        public virtual ca_real_estate_asset ca_real_estate_asset { get; set; }
    }
}
