namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_loan_details
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ca_loan_details()
        {
            ca_loan_details_lending_purpose = new HashSet<ca_loan_details_lending_purpose>();
            ca_loan_details_loan_auto_decision = new HashSet<ca_loan_details_loan_auto_decision>();
            ca_loan_details_loan_score_card = new HashSet<ca_loan_details_loan_score_card>();
            ca_loan_details_percent_owned_owner = new HashSet<ca_loan_details_percent_owned_owner>();
        }

        [Key]
        public int ca_loan_details_id { get; set; }

        public int ca_credit_application_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public decimal? amount_requested { get; set; }

        public decimal? proposed_annual_interest_rate { get; set; }

        public int? loan_type { get; set; }

        public decimal? ed_total_security_value { get; set; }

        public decimal? ed_loan_to_value_ratio { get; set; }

        [StringLength(36)]
        public string product_code { get; set; }

        public int? ed_base_credit_score { get; set; }

        public int? ed_score_card_score { get; set; }

        public int? ed_auto_decision_status { get; set; }

        [StringLength(100)]
        public string product_name { get; set; }

        public int? ed_product_type { get; set; }

        public int? percent_owned_proportions_type { get; set; }

        public virtual ad_ca_loan_type ad_ca_loan_type { get; set; }

        public virtual ad_ca_proportions_type ad_ca_proportions_type { get; set; }

        public virtual ad_ca_status_name_application_instructions_type ad_ca_status_name_application_instructions_type { get; set; }

        public virtual ad_pd_product_type ad_pd_product_type { get; set; }

        public virtual ca_credit_application ca_credit_application { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_loan_details_lending_purpose> ca_loan_details_lending_purpose { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_loan_details_loan_auto_decision> ca_loan_details_loan_auto_decision { get; set; }

        public virtual ca_loan_details_loan_purpose ca_loan_details_loan_purpose { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_loan_details_loan_score_card> ca_loan_details_loan_score_card { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_loan_details_percent_owned_owner> ca_loan_details_percent_owned_owner { get; set; }

        public virtual ca_loan_details_proposed_repayment ca_loan_details_proposed_repayment { get; set; }

        public virtual ca_loan_details_term ca_loan_details_term { get; set; }
    }
}
