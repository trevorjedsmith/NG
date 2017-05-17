namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_other_income
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ca_other_income()
        {
            ca_other_income_percent_owned_owner = new HashSet<ca_other_income_percent_owned_owner>();
        }

        [Key]
        public int ca_other_income_id { get; set; }

        public int ca_credit_application_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(100)]
        public string benefits_description { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        public int? frequency_short_type { get; set; }

        public int? government_benefits_type { get; set; }

        public int? other_income_type { get; set; }

        public int? percent_owned_proportions_type { get; set; }

        public decimal? ed_net_amount { get; set; }

        public decimal? ed_monthly_net_amount { get; set; }

        public decimal? ed_percent_for_affordability { get; set; }

        public int? country_code { get; set; }

        [Column(TypeName = "date")]
        public DateTime? end_date { get; set; }

        public int? income_verification_type { get; set; }

        public int? proof_code_other_type { get; set; }

        public bool? proof_sighted { get; set; }

        [Column(TypeName = "date")]
        public DateTime? start_date { get; set; }

        public bool? taxed { get; set; }

        public decimal? ed_gross_amount { get; set; }

        public decimal? ed_monthly_gross_amount { get; set; }

        public virtual ad_ca_country_code ad_ca_country_code { get; set; }

        public virtual ad_ca_frequency_short_type ad_ca_frequency_short_type { get; set; }

        public virtual ad_ca_government_benefits_type ad_ca_government_benefits_type { get; set; }

        public virtual ad_ca_income_verification_type ad_ca_income_verification_type { get; set; }

        public virtual ad_ca_other_income_type ad_ca_other_income_type { get; set; }

        public virtual ad_ca_proof_code_other_type ad_ca_proof_code_other_type { get; set; }

        public virtual ad_ca_proportions_type ad_ca_proportions_type { get; set; }

        public virtual ca_credit_application ca_credit_application { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_other_income_percent_owned_owner> ca_other_income_percent_owned_owner { get; set; }
    }
}
