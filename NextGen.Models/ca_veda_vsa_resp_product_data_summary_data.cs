namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_vsa_resp_product_data_summary_data
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ca_veda_vsa_resp_product_data_summary_data()
        {
            ca_veda_vsa_resp_summary_data_data_block = new HashSet<ca_veda_vsa_resp_summary_data_data_block>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_veda_vsa_resp_product_data_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public virtual ca_veda_vsa_resp_product_data ca_veda_vsa_resp_product_data { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_veda_vsa_resp_summary_data_data_block> ca_veda_vsa_resp_summary_data_data_block { get; set; }
    }
}
