namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_ed_account_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ad_ed_account_type()
        {
            ca_non_real_estate_asset_financial_asset_account_number = new HashSet<ca_non_real_estate_asset_financial_asset_account_number>();
        }

        [Key]
        public int ad_ed_account_type_id { get; set; }

        [StringLength(100)]
        public string lending_description { get; set; }

        [StringLength(100)]
        public string core_description { get; set; }

        [StringLength(36)]
        public string core_code { get; set; }

        [StringLength(5)]
        public string core_account_type { get; set; }

        public bool active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_non_real_estate_asset_financial_asset_account_number> ca_non_real_estate_asset_financial_asset_account_number { get; set; }
    }
}
