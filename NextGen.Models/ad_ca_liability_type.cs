namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_ca_liability_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ad_ca_liability_type()
        {
            ca_liability = new HashSet<ca_liability>();
        }

        [Key]
        public int ad_ca_liability_type_id { get; set; }

        [StringLength(100)]
        public string lending_description { get; set; }

        [StringLength(100)]
        public string lixi_description { get; set; }

        [StringLength(100)]
        public string symtrix_description { get; set; }

        [StringLength(100)]
        public string core_description { get; set; }

        public decimal? percent_for_affordability { get; set; }

        public bool active { get; set; }

        [StringLength(36)]
        public string core_application_type { get; set; }

        [StringLength(36)]
        public string core_account_type { get; set; }

        [StringLength(36)]
        public string core_overdraft_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_liability> ca_liability { get; set; }
    }
}
