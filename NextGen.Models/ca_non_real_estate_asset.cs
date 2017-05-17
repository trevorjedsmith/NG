namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_non_real_estate_asset
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ca_non_real_estate_asset()
        {
            ca_non_real_estate_asset_insurance = new HashSet<ca_non_real_estate_asset_insurance>();
            ca_non_real_estate_asset_percent_owned_owner = new HashSet<ca_non_real_estate_asset_percent_owned_owner>();
        }

        [Key]
        public int ca_non_real_estate_asset_id { get; set; }

        public int ca_credit_application_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public bool? contract_of_sale { get; set; }

        public bool? encumbered { get; set; }

        public int? financial_transaction_type { get; set; }

        public bool? primary_security { get; set; }

        public bool? to_be_sold { get; set; }

        public bool? to_be_used_as_security { get; set; }

        public int? asset_transaction_type { get; set; }

        public int? non_real_estate_asset_type { get; set; }

        public int? percent_owned_proportions_type { get; set; }

        public int? ed_core_assetid { get; set; }

        public bool? ed_verified { get; set; }

        public virtual ad_ca_asset_transaction_type ad_ca_asset_transaction_type { get; set; }

        public virtual ad_ca_financial_transaction_type ad_ca_financial_transaction_type { get; set; }

        public virtual ad_ca_non_real_estate_asset_type ad_ca_non_real_estate_asset_type { get; set; }

        public virtual ad_ca_proportions_type ad_ca_proportions_type { get; set; }

        public virtual ca_credit_application ca_credit_application { get; set; }

        public virtual ca_non_real_estate_asset_estimated_value ca_non_real_estate_asset_estimated_value { get; set; }

        public virtual ca_non_real_estate_asset_financial_asset ca_non_real_estate_asset_financial_asset { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_non_real_estate_asset_insurance> ca_non_real_estate_asset_insurance { get; set; }

        public virtual ca_non_real_estate_asset_motor_vehicle ca_non_real_estate_asset_motor_vehicle { get; set; }

        public virtual ca_non_real_estate_asset_other_asset ca_non_real_estate_asset_other_asset { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_non_real_estate_asset_percent_owned_owner> ca_non_real_estate_asset_percent_owned_owner { get; set; }
    }
}
