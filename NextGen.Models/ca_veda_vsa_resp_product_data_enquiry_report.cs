namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_vsa_resp_product_data_enquiry_report
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_veda_vsa_resp_product_data_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public virtual ca_veda_vsa_resp_enquiry_report_pub_rec_or_cons_credit_info ca_veda_vsa_resp_enquiry_report_pub_rec_or_cons_credit_info { get; set; }

        public virtual ca_veda_vsa_resp_product_data ca_veda_vsa_resp_product_data { get; set; }
    }
}
