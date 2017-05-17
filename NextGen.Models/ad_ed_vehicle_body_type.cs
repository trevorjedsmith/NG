namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_ed_vehicle_body_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ad_ed_vehicle_body_type()
        {
            ca_non_real_estate_asset_motor_vehicle = new HashSet<ca_non_real_estate_asset_motor_vehicle>();
        }

        [Key]
        public int ad_ed_vehicle_body_type_id { get; set; }

        [StringLength(100)]
        public string lending_description { get; set; }

        public bool active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_non_real_estate_asset_motor_vehicle> ca_non_real_estate_asset_motor_vehicle { get; set; }
    }
}
