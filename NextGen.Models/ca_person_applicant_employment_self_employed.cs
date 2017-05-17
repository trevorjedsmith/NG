namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_person_applicant_employment_self_employed
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_person_applicant_employment_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public int? self_employed_basis_type { get; set; }

        [StringLength(100)]
        public string occupation { get; set; }

        public int? abs_occupation_code { get; set; }

        public int? employment_status_type { get; set; }

        [Column(TypeName = "date")]
        public DateTime? start_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? end_date { get; set; }

        public bool? ed_income_credited_to_internal_account { get; set; }

        public int? employer_ca_related_company_id { get; set; }

        [StringLength(36)]
        public string ed_employer_ca_related_company_external_guid { get; set; }

        public virtual ad_ca_abs_occupation_code ad_ca_abs_occupation_code { get; set; }

        public virtual ad_ca_employment_status_type ad_ca_employment_status_type { get; set; }

        public virtual ad_ca_self_employed_basis_type ad_ca_self_employed_basis_type { get; set; }

        public virtual ca_person_applicant_employment ca_person_applicant_employment { get; set; }

        public virtual ca_person_applicant_employment_self_employed_business ca_person_applicant_employment_self_employed_business { get; set; }

        public virtual ca_person_applicant_employment_self_employed_business_income_recent ca_person_applicant_employment_self_employed_business_income_recent { get; set; }

        public virtual ca_related_company ca_related_company { get; set; }
    }
}
