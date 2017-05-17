namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_ca_frequency_full_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ad_ca_frequency_full_type()
        {
            ad_pd_product_type = new HashSet<ad_pd_product_type>();
            ca_loan_details_proposed_repayment = new HashSet<ca_loan_details_proposed_repayment>();
        }

        [Key]
        public int ad_ca_frequency_full_type_id { get; set; }

        [StringLength(100)]
        public string lending_description { get; set; }

        [StringLength(100)]
        public string lixi_description { get; set; }

        [StringLength(100)]
        public string symtrix_description { get; set; }

        public bool active { get; set; }

        public int? occurance_per_year { get; set; }

        public decimal? monthly_conversion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ad_pd_product_type> ad_pd_product_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_loan_details_proposed_repayment> ca_loan_details_proposed_repayment { get; set; }
    }
}
