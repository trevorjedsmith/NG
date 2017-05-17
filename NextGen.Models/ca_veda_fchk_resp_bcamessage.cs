namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_fchk_resp_bcamessage
    {
        [Key]
        public int ca_veda_fchk_resp_bcamessage_id { get; set; }

        public int ca_person_applicant_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(50)]
        public string service_request_id { get; set; }

        [StringLength(50)]
        public string message_type { get; set; }

        [StringLength(1)]
        public string ed_fraudcheck_result { get; set; }

        public virtual ca_person_applicant ca_person_applicant { get; set; }

        public virtual ca_veda_fchk_resp_bcaservices ca_veda_fchk_resp_bcaservices { get; set; }
    }
}
