namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_household
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ca_household()
        {
            ca_household_applicant = new HashSet<ca_household_applicant>();
            ca_household_living_expense = new HashSet<ca_household_living_expense>();
            ca_household_other_commitment = new HashSet<ca_household_other_commitment>();
        }

        [Key]
        public int ca_household_id { get; set; }

        public int ca_credit_application_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        public short? number_of_adults { get; set; }

        public short? number_of_dependants { get; set; }

        public short? ed_dependants_less_than_12 { get; set; }

        public decimal? ed_standardised_living_expense_amount { get; set; }

        public virtual ca_credit_application ca_credit_application { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_household_applicant> ca_household_applicant { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_household_living_expense> ca_household_living_expense { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_household_other_commitment> ca_household_other_commitment { get; set; }
    }
}
