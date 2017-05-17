namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_real_estate_asset
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ca_real_estate_asset()
        {
            ca_real_estate_asset_insurance = new HashSet<ca_real_estate_asset_insurance>();
            ca_real_estate_asset_percent_owned_owner = new HashSet<ca_real_estate_asset_percent_owned_owner>();
            ca_real_estate_asset_title = new HashSet<ca_real_estate_asset_title>();
        }

        [Key]
        public int ca_real_estate_asset_id { get; set; }

        public int ca_credit_application_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public int? primary_usage_type { get; set; }

        public int? percent_owned_proportions_type { get; set; }

        public int? address_ca_address_id { get; set; }

        [StringLength(36)]
        public string ed_address_ca_address_external_guid { get; set; }

        public bool? approval_in_principle { get; set; }

        public bool? construction { get; set; }

        public bool? contract_of_sale { get; set; }

        public int? data_source_type { get; set; }

        public bool? encumbered { get; set; }

        public int? holding_type { get; set; }

        public bool? investment_property_letter { get; set; }

        public bool? legal_representation { get; set; }

        public int? nras_consortium_type { get; set; }

        public bool? nras_property { get; set; }

        public int? occupancy_type { get; set; }

        public bool? on_market_transaction { get; set; }

        [StringLength(100)]
        public string primary_land_use { get; set; }

        public int? primary_purpose_real_estate_asset_type { get; set; }

        public bool? primary_security { get; set; }

        [StringLength(50)]
        public string propertyid { get; set; }

        public bool? purchase_under_aoc_wrap { get; set; }

        public int? real_estate_asset_status_type { get; set; }

        public bool? to_be_sold { get; set; }

        public bool? to_be_used_as_security { get; set; }

        public int? asset_transaction_type { get; set; }

        public int? valuation_program_type { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ed_valuation_date { get; set; }

        public int? ed_core_assetid { get; set; }

        public bool? ed_verified { get; set; }

        public int? property_type_name_type { get; set; }

        public virtual ad_ca_asset_transaction_type ad_ca_asset_transaction_type { get; set; }

        public virtual ad_ca_data_source_type ad_ca_data_source_type { get; set; }

        public virtual ad_ca_holding_type ad_ca_holding_type { get; set; }

        public virtual ad_ca_nras_consortium_type ad_ca_nras_consortium_type { get; set; }

        public virtual ad_ca_occupancy_type ad_ca_occupancy_type { get; set; }

        public virtual ad_ca_primary_purpose_real_estate_asset_type ad_ca_primary_purpose_real_estate_asset_type { get; set; }

        public virtual ad_ca_primary_usage_type ad_ca_primary_usage_type { get; set; }

        public virtual ad_ca_proportions_type ad_ca_proportions_type { get; set; }

        public virtual ad_ca_real_estate_asset_status_type ad_ca_real_estate_asset_status_type { get; set; }

        public virtual ad_ca_valuation_program_type ad_ca_valuation_program_type { get; set; }

        public virtual ad_ed_property_type_name_type ad_ed_property_type_name_type { get; set; }

        public virtual ca_address ca_address { get; set; }

        public virtual ca_credit_application ca_credit_application { get; set; }

        public virtual ca_real_estate_asset_commercial ca_real_estate_asset_commercial { get; set; }

        public virtual ca_real_estate_asset_estimated_value ca_real_estate_asset_estimated_value { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_real_estate_asset_insurance> ca_real_estate_asset_insurance { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_real_estate_asset_percent_owned_owner> ca_real_estate_asset_percent_owned_owner { get; set; }

        public virtual ca_real_estate_asset_rental_income ca_real_estate_asset_rental_income { get; set; }

        public virtual ca_real_estate_asset_residential ca_real_estate_asset_residential { get; set; }

        public virtual ca_real_estate_asset_rural ca_real_estate_asset_rural { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_real_estate_asset_title> ca_real_estate_asset_title { get; set; }
    }
}
