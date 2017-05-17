namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_ca_balloon_rv_input_pattern_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ad_ca_balloon_rv_input_pattern_type()
        {
            ca_non_real_estate_asset_estimated_value = new HashSet<ca_non_real_estate_asset_estimated_value>();
        }

        [Key]
        public int ad_ca_balloon_rv_input_pattern_type_id { get; set; }

        [StringLength(100)]
        public string lending_description { get; set; }

        [StringLength(100)]
        public string lixi_description { get; set; }

        public bool active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_non_real_estate_asset_estimated_value> ca_non_real_estate_asset_estimated_value { get; set; }
    }
}
