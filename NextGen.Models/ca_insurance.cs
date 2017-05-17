namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_insurance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ca_insurance()
        {
            ca_non_real_estate_asset_insurance = new HashSet<ca_non_real_estate_asset_insurance>();
            ca_real_estate_asset_insurance = new HashSet<ca_real_estate_asset_insurance>();
        }

        [Key]
        public int ca_insurance_id { get; set; }

        public int ca_credit_application_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        [Column(TypeName = "date")]
        public DateTime? effective_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? expiry_date { get; set; }

        public int? insurance_type { get; set; }

        public decimal? insured_amount { get; set; }

        public int? insurer_type { get; set; }

        [StringLength(100)]
        public string other_insurer_name { get; set; }

        [StringLength(50)]
        public string policy_number { get; set; }

        public int? insurance_how_paid_type { get; set; }

        public virtual ad_ca_insurance_type ad_ca_insurance_type { get; set; }

        public virtual ad_ca_insurer_type ad_ca_insurer_type { get; set; }

        public virtual ad_ed_insurance_how_paid_type ad_ed_insurance_how_paid_type { get; set; }

        public virtual ca_credit_application ca_credit_application { get; set; }

        public virtual ca_insurance_commission_payable ca_insurance_commission_payable { get; set; }

        public virtual ca_insurance_premium ca_insurance_premium { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_non_real_estate_asset_insurance> ca_non_real_estate_asset_insurance { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_real_estate_asset_insurance> ca_real_estate_asset_insurance { get; set; }
    }
}
