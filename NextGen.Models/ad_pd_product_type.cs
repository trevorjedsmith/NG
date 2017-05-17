namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_pd_product_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ad_pd_product_type()
        {
            ca_loan_details = new HashSet<ca_loan_details>();
        }

        [Key]
        public int ad_pd_product_type_id { get; set; }

        [Required]
        [StringLength(36)]
        public string product_code { get; set; }

        public int? ad_ca_loan_type_id { get; set; }

        public int? ad_ca_application_type_id { get; set; }

        [StringLength(200)]
        public string product_description { get; set; }

        public decimal? annual_interest_rate { get; set; }

        [StringLength(32)]
        public string core_deposit_account_type { get; set; }

        [StringLength(32)]
        public string core_deposit_class_code { get; set; }

        [StringLength(32)]
        public string core_loan_account_type { get; set; }

        [StringLength(32)]
        public string core_loan_class_code { get; set; }

        public int? core_capitalized_term { get; set; }

        [StringLength(8)]
        public string core_capitalized_period { get; set; }

        [StringLength(40)]
        public string core_insurance_company { get; set; }

        [StringLength(40)]
        public string core_insurance_type { get; set; }

        public int? ad_ed_veda_account_type_id { get; set; }

        public decimal? min_loan_details_amount { get; set; }

        public decimal? max_loan_details_amount { get; set; }

        public decimal? cash_advance_interest_rate { get; set; }

        public short? interest_free_days { get; set; }

        public short? base_scorecard_score { get; set; }

        public int? ad_ca_frequency_full_type_id { get; set; }

        [StringLength(9)]
        public string core_advance { get; set; }

        [StringLength(8)]
        public string core_loan_period { get; set; }

        [StringLength(14)]
        public string core_late_assess_method { get; set; }

        [StringLength(15)]
        public string core_payment_type { get; set; }

        public virtual ad_ca_application_type ad_ca_application_type { get; set; }

        public virtual ad_ca_frequency_full_type ad_ca_frequency_full_type { get; set; }

        public virtual ad_ca_loan_type ad_ca_loan_type { get; set; }

        public virtual ad_ed_veda_account_type ad_ed_veda_account_type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_loan_details> ca_loan_details { get; set; }
    }
}
