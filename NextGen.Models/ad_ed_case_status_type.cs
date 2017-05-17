namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_ed_case_status_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ad_ed_case_status_type()
        {
            ca_case_data = new HashSet<ca_case_data>();
        }

        [Key]
        public int ad_ed_case_status_type_id { get; set; }

        [StringLength(100)]
        public string lending_description { get; set; }

        [StringLength(36)]
        public string lending_code { get; set; }

        public bool active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_case_data> ca_case_data { get; set; }
    }
}
