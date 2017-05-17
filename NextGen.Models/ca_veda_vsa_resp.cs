namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_vsa_resp
    {
        [Key]
        public int ca_veda_vsa_resp_id { get; set; }

        public int ca_person_applicant_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public virtual ca_person_applicant ca_person_applicant { get; set; }

        public virtual ca_veda_vsa_resp_product_data ca_veda_vsa_resp_product_data { get; set; }
    }
}
