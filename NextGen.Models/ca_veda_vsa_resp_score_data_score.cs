namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_vsa_resp_score_data_score
    {
        [Key]
        public int ca_veda_vsa_resp_score_data_score_id { get; set; }

        public int ca_veda_vsa_resp_product_data_score_data_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public int? score_masterscale { get; set; }

        public virtual ca_veda_vsa_resp_product_data_score_data ca_veda_vsa_resp_product_data_score_data { get; set; }
    }
}
