namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_vsa_resp_product_data
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_veda_vsa_resp_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public virtual ca_veda_vsa_resp ca_veda_vsa_resp { get; set; }

        public virtual ca_veda_vsa_resp_product_data_enquiry_report ca_veda_vsa_resp_product_data_enquiry_report { get; set; }

        public virtual ca_veda_vsa_resp_product_data_score_data ca_veda_vsa_resp_product_data_score_data { get; set; }

        public virtual ca_veda_vsa_resp_product_data_summary_data ca_veda_vsa_resp_product_data_summary_data { get; set; }
    }
}
