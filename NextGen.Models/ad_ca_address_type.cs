namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_ca_address_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ad_ca_address_type()
        {
            ca_address = new HashSet<ca_address>();
        }

        [Key]
        public int ad_ca_address_type_id { get; set; }

        [StringLength(100)]
        public string lending_description { get; set; }

        [StringLength(100)]
        public string lixi_description { get; set; }

        public bool active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_address> ca_address { get; set; }
    }
}
