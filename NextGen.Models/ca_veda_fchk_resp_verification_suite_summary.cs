namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_fchk_resp_verification_suite_summary
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_veda_fchk_resp_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(25)]
        public string vericheck_indicator_result { get; set; }

        [StringLength(25)]
        public string fraudcheck_indicator_result { get; set; }

        public virtual ca_veda_fchk_resp ca_veda_fchk_resp { get; set; }
    }
}
