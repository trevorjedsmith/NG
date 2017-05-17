namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_fchk_resp_fchk_report_fchk_result
    {
        [Key]
        public int ca_veda_fchk_resp_fchk_report_fchk_result_id { get; set; }

        public int ca_veda_fchk_resp_fchk_report_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(10)]
        public string fraud_file_number { get; set; }

        public virtual ca_veda_fchk_resp_fchk_report ca_veda_fchk_resp_fchk_report { get; set; }

        public virtual ca_veda_fchk_resp_fchk_result_details ca_veda_fchk_resp_fchk_result_details { get; set; }

        public virtual ca_veda_fchk_resp_fchk_result_summary ca_veda_fchk_resp_fchk_result_summary { get; set; }
    }
}
