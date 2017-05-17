namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_ed_credit_application_condition_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ad_ed_credit_application_condition_type()
        {
            ca_credit_application_conditions = new HashSet<ca_credit_application_conditions>();
        }

        [Key]
        public int ad_ed_credit_application_condition_type_id { get; set; }

        [StringLength(500)]
        public string lending_description { get; set; }

        public bool active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_credit_application_conditions> ca_credit_application_conditions { get; set; }
    }
}
