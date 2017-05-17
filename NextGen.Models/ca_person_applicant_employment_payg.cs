namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_person_applicant_employment_payg
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_person_applicant_employment_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        [Column(TypeName = "date")]
        public DateTime? start_date { get; set; }

        public int? payg_basis_type { get; set; }

        public decimal? income_gross_salary_amount { get; set; }

        public int? income_gross_salary_frequency_short_type { get; set; }

        public decimal? ed_income_monthly_gross_salary_amount { get; set; }

        public decimal? ed_income_net_salary_amount { get; set; }

        public decimal? ed_income_monthly_net_salary_amount { get; set; }

        public decimal? ed_income_gross_salary_percent_for_affordability { get; set; }

        [Column(TypeName = "date")]
        public DateTime? end_date { get; set; }

        [StringLength(100)]
        public string occupation { get; set; }

        public int? abs_occupation_code { get; set; }

        public int? employment_status_type { get; set; }

        public bool ed_logically_deleted { get; set; }

        public bool? ed_income_credited_to_internal_account { get; set; }

        public int? employer_ca_related_company_id { get; set; }

        [StringLength(36)]
        public string ed_employer_ca_related_company_external_guid { get; set; }

        public virtual ad_ca_abs_occupation_code ad_ca_abs_occupation_code { get; set; }

        public virtual ad_ca_employment_status_type ad_ca_employment_status_type { get; set; }

        public virtual ad_ca_frequency_short_type ad_ca_frequency_short_type { get; set; }

        public virtual ad_ca_payg_basis_type ad_ca_payg_basis_type { get; set; }

        public virtual ca_person_applicant_employment ca_person_applicant_employment { get; set; }

        public virtual ca_related_company ca_related_company { get; set; }
    }
}
