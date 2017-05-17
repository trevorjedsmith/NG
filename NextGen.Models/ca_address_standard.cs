namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_address_standard
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_address_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(100)]
        public string building_name { get; set; }

        [StringLength(10)]
        public string level { get; set; }

        [StringLength(100)]
        public string street_name { get; set; }

        [StringLength(10)]
        public string street_number { get; set; }

        [StringLength(10)]
        public string unit { get; set; }

        public int? street_suffix_type { get; set; }

        public int? street_type { get; set; }

        public virtual ad_ca_street_suffix_type ad_ca_street_suffix_type { get; set; }

        public virtual ad_ca_street_type ad_ca_street_type { get; set; }

        public virtual ca_address ca_address { get; set; }
    }
}
