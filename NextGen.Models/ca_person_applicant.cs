namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_person_applicant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ca_person_applicant()
        {
            ca_household_applicant = new HashSet<ca_household_applicant>();
            ca_household_living_expense_percent_responsible_owner = new HashSet<ca_household_living_expense_percent_responsible_owner>();
            ca_household_other_commitment_percent_responsible_owner = new HashSet<ca_household_other_commitment_percent_responsible_owner>();
            ca_liability_percent_owned_owner = new HashSet<ca_liability_percent_owned_owner>();
            ca_loan_details_percent_owned_owner = new HashSet<ca_loan_details_percent_owned_owner>();
            ca_non_real_estate_asset_percent_owned_owner = new HashSet<ca_non_real_estate_asset_percent_owned_owner>();
            ca_other_income_percent_owned_owner = new HashSet<ca_other_income_percent_owned_owner>();
            ca_person_applicant_employment = new HashSet<ca_person_applicant_employment>();
            ca_person_applicant_proof_of_identity = new HashSet<ca_person_applicant_proof_of_identity>();
            ca_real_estate_asset_percent_owned_owner = new HashSet<ca_real_estate_asset_percent_owned_owner>();
            ca_related_company_partner_percent_owned = new HashSet<ca_related_company_partner_percent_owned>();
            ca_veda_fchk_resp_bcamessage = new HashSet<ca_veda_fchk_resp_bcamessage>();
            ca_veda_vsa_resp = new HashSet<ca_veda_vsa_resp>();
        }

        [Key]
        public int ca_person_applicant_id { get; set; }

        public int ca_credit_application_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_of_birth { get; set; }

        public bool? is_existing_customer { get; set; }

        public bool? primary_applicant { get; set; }

        [StringLength(50)]
        public string person_name_first_name { get; set; }

        [StringLength(50)]
        public string person_name_surname { get; set; }

        [StringLength(50)]
        public string existing_customer_customer_number { get; set; }

        public short? ed_age { get; set; }

        public bool? ed_living_with_direct_relative { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ed_existing_customer_effective_date { get; set; }

        public decimal? ed_existing_customer_years_as_member { get; set; }

        public int? ed_existing_customer_member_class_type { get; set; }

        [StringLength(50)]
        public string person_name_middle_names { get; set; }

        [StringLength(50)]
        public string person_name_known_as { get; set; }

        public int? person_name_name_title_type { get; set; }

        public int? gender_type { get; set; }

        public int? principal_foreign_residence_type { get; set; }

        public int? marital_status_type { get; set; }

        public int? applicant_type { get; set; }

        public virtual ad_ca_applicant_type ad_ca_applicant_type { get; set; }

        public virtual ad_ca_country_code ad_ca_country_code { get; set; }

        public virtual ad_ca_gender_type ad_ca_gender_type { get; set; }

        public virtual ad_ca_marital_status_type ad_ca_marital_status_type { get; set; }

        public virtual ad_ca_name_title_type ad_ca_name_title_type { get; set; }

        public virtual ad_ed_member_class_type ad_ed_member_class_type { get; set; }

        public virtual ca_credit_application ca_credit_application { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_household_applicant> ca_household_applicant { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_household_living_expense_percent_responsible_owner> ca_household_living_expense_percent_responsible_owner { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_household_other_commitment_percent_responsible_owner> ca_household_other_commitment_percent_responsible_owner { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_liability_percent_owned_owner> ca_liability_percent_owned_owner { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_loan_details_percent_owned_owner> ca_loan_details_percent_owned_owner { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_non_real_estate_asset_percent_owned_owner> ca_non_real_estate_asset_percent_owned_owner { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_other_income_percent_owned_owner> ca_other_income_percent_owned_owner { get; set; }

        public virtual ca_person_applicant_affordability ca_person_applicant_affordability { get; set; }

        public virtual ca_person_applicant_contact ca_person_applicant_contact { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_person_applicant_employment> ca_person_applicant_employment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_person_applicant_proof_of_identity> ca_person_applicant_proof_of_identity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_real_estate_asset_percent_owned_owner> ca_real_estate_asset_percent_owned_owner { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_related_company_partner_percent_owned> ca_related_company_partner_percent_owned { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_veda_fchk_resp_bcamessage> ca_veda_fchk_resp_bcamessage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_veda_vsa_resp> ca_veda_vsa_resp { get; set; }
    }
}
