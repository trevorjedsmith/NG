namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_person_applicant_employment_not_employed
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_person_applicant_employment_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public bool? home_duties { get; set; }

        public bool? on_benefits { get; set; }

        public bool? retired { get; set; }

        public bool? student { get; set; }

        [Column(TypeName = "date")]
        public DateTime? start_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? end_date { get; set; }

        public int? employment_status_type { get; set; }

        public int? income_superannuation_frequency_short_type { get; set; }

        public decimal? ed_income_net_superannuation_amount { get; set; }

        public decimal? ed_income_monthly_net_superannuation_amount { get; set; }

        public decimal? ed_income_superannuation_amount_percent_for_affordability { get; set; }

        public int? income_private_pension_frequency_short_type { get; set; }

        public decimal? ed_income_net_private_pension_amount { get; set; }

        public decimal? ed_income_monthly_net_private_pension_amount { get; set; }

        public decimal? ed_income_private_pension_amount_percent_for_affordability { get; set; }

        public int? income_other_income_frequency_short_type { get; set; }

        public decimal? ed_income_net_other_income_amount { get; set; }

        public decimal? ed_income_monthly_net_other_income_amount { get; set; }

        public decimal? ed_income_other_income_amount_percent_for_affordability { get; set; }

        public bool? ed_income_credited_to_internal_account { get; set; }

        public decimal? ed_income_gross_superannuation_amount { get; set; }

        public decimal? ed_income_monthly_gross_superannuation_amount { get; set; }

        public decimal? ed_income_gross_private_pension_amount { get; set; }

        public decimal? ed_income_monthly_gross_private_pension_amount { get; set; }

        public decimal? ed_income_gross_other_income_amount { get; set; }

        public decimal? ed_income_monthly_gross_other_income_amount { get; set; }

        public virtual ad_ca_employment_status_type ad_ca_employment_status_type { get; set; }

        public virtual ad_ca_frequency_short_type ad_ca_frequency_short_type { get; set; }

        public virtual ad_ca_frequency_short_type ad_ca_frequency_short_type1 { get; set; }

        public virtual ad_ca_frequency_short_type ad_ca_frequency_short_type2 { get; set; }

        public virtual ca_person_applicant_employment ca_person_applicant_employment { get; set; }
    }
}
