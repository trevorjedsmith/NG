namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_liability
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ca_liability()
        {
            ca_liability_percent_owned_owner = new HashSet<ca_liability_percent_owned_owner>();
        }

        [Key]
        public int ca_liability_id { get; set; }

        public int ca_credit_application_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public decimal? credit_limit { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        public decimal? outstanding_balance { get; set; }

        public int? liability_type { get; set; }

        public int? percent_owned_proportions_type { get; set; }

        public decimal? repayment_amount { get; set; }

        public int? repayment_frequency_type { get; set; }

        public decimal? ed_repayment_monthly_amount { get; set; }

        public decimal? ed_repayment_percent_for_affordability { get; set; }

        public decimal? ed_ara_adjustment_monthly_amount { get; set; }

        public decimal? ed_ara_repayment_monthly_amount { get; set; }

        public bool? ed_proposed_commitment { get; set; }

        public int? repayment_payment_type { get; set; }

        public int? remaining_term_duration { get; set; }

        public int? remaining_term_loan_term_units_type { get; set; }

        public bool? clearing_from_this_loan { get; set; }

        public decimal? arrears_amount { get; set; }

        public short? arrears_number_of_missed_payments { get; set; }

        public decimal? in_advance_amount { get; set; }

        public decimal? undisbursed_amount { get; set; }

        public decimal? annual_interest_rate { get; set; }

        public bool? ed_verified { get; set; }

        public decimal? ed_core_value { get; set; }

        public int? ed_interest_only_remaining_term_duration { get; set; }

        public int? ed_interest_only_repayment_frequency_type { get; set; }

        public virtual ad_ca_liability_type ad_ca_liability_type { get; set; }

        public virtual ad_ca_loan_term_units_type ad_ca_loan_term_units_type { get; set; }

        public virtual ad_ca_payment_type ad_ca_payment_type { get; set; }

        public virtual ad_ca_proportions_type ad_ca_proportions_type { get; set; }

        public virtual ad_ca_repayment_frequency_type ad_ca_repayment_frequency_type { get; set; }

        public virtual ad_ca_repayment_frequency_type ad_ca_repayment_frequency_type1 { get; set; }

        public virtual ca_credit_application ca_credit_application { get; set; }

        public virtual ca_liability_account_number ca_liability_account_number { get; set; }

        public virtual ca_liability_account_performance ca_liability_account_performance { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_liability_percent_owned_owner> ca_liability_percent_owned_owner { get; set; }
    }
}
