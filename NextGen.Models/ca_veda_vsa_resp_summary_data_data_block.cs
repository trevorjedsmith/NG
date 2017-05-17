namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_vsa_resp_summary_data_data_block
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ca_veda_vsa_resp_summary_data_data_block()
        {
            ca_veda_vsa_resp_data_block_characteristic = new HashSet<ca_veda_vsa_resp_data_block_characteristic>();
        }

        [Key]
        public int ca_veda_vsa_resp_summary_data_data_block_id { get; set; }

        public int ca_veda_vsa_resp_product_data_summary_data_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(8)]
        public string block_type { get; set; }

        [StringLength(50)]
        public string block_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_veda_vsa_resp_data_block_characteristic> ca_veda_vsa_resp_data_block_characteristic { get; set; }

        public virtual ca_veda_vsa_resp_product_data_summary_data ca_veda_vsa_resp_product_data_summary_data { get; set; }
    }
}
