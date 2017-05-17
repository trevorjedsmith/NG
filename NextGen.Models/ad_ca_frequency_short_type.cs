namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_ca_frequency_short_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ad_ca_frequency_short_type()
        {
            ca_household_living_expense = new HashSet<ca_household_living_expense>();
            ca_household_other_commitment = new HashSet<ca_household_other_commitment>();
            ca_insurance_premium = new HashSet<ca_insurance_premium>();
            ca_other_income = new HashSet<ca_other_income>();
            ca_person_applicant_employment_not_employed = new HashSet<ca_person_applicant_employment_not_employed>();
            ca_person_applicant_employment_not_employed1 = new HashSet<ca_person_applicant_employment_not_employed>();
            ca_person_applicant_employment_not_employed2 = new HashSet<ca_person_applicant_employment_not_employed>();
            ca_person_applicant_employment_payg = new HashSet<ca_person_applicant_employment_payg>();
            ca_real_estate_asset_rental_income = new HashSet<ca_real_estate_asset_rental_income>();
        }

        [Key]
        public int ad_ca_frequency_short_type_id { get; set; }

        [StringLength(100)]
        public string lending_description { get; set; }

        [StringLength(100)]
        public string lixi_description { get; set; }

        public bool active { get; set; }

        public int? occurance_per_year { get; set; }

        public decimal? monthly_conversion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_household_living_expense> ca_household_living_expense { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_household_other_commitment> ca_household_other_commitment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_insurance_premium> ca_insurance_premium { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_other_income> ca_other_income { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_person_applicant_employment_not_employed> ca_person_applicant_employment_not_employed { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_person_applicant_employment_not_employed> ca_person_applicant_employment_not_employed1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_person_applicant_employment_not_employed> ca_person_applicant_employment_not_employed2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_person_applicant_employment_payg> ca_person_applicant_employment_payg { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_real_estate_asset_rental_income> ca_real_estate_asset_rental_income { get; set; }
    }
}
