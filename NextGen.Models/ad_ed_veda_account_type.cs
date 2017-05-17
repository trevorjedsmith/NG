namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_ed_veda_account_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ad_ed_veda_account_type()
        {
            ad_pd_product_type = new HashSet<ad_pd_product_type>();
        }

        [Key]
        public int ad_ed_veda_account_type_id { get; set; }

        [StringLength(2)]
        public string code { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        public bool consumer { get; set; }

        public bool commercial { get; set; }

        public bool active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ad_pd_product_type> ad_pd_product_type { get; set; }
    }
}
