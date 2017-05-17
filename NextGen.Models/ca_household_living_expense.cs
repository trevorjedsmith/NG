namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_household_living_expense
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ca_household_living_expense()
        {
            ca_household_living_expense_percent_responsible_owner = new HashSet<ca_household_living_expense_percent_responsible_owner>();
        }

        [Key]
        public int ca_household_living_expense_id { get; set; }

        public int ca_household_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public decimal? amount { get; set; }

        public int? living_expense_category_type { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        [Column(TypeName = "date")]
        public DateTime? end_date { get; set; }

        public int? frequency_short_type { get; set; }

        [Column(TypeName = "date")]
        public DateTime? start_date { get; set; }

        public int? percent_responsible_proportions_type { get; set; }

        public decimal? ed_monthly_amount { get; set; }

        public decimal? ed_percent_for_affordability { get; set; }

        public virtual ad_ca_frequency_short_type ad_ca_frequency_short_type { get; set; }

        public virtual ad_ca_living_expense_category_type ad_ca_living_expense_category_type { get; set; }

        public virtual ad_ca_proportions_type ad_ca_proportions_type { get; set; }

        public virtual ca_household ca_household { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_household_living_expense_percent_responsible_owner> ca_household_living_expense_percent_responsible_owner { get; set; }
    }
}
