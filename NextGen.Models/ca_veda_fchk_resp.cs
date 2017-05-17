namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_fchk_resp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_veda_fchk_resp_bcaservice_data_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(25)]
        public string version { get; set; }

        public virtual ca_veda_fchk_resp_bcaservice_data ca_veda_fchk_resp_bcaservice_data { get; set; }

        public virtual ca_veda_fchk_resp_error ca_veda_fchk_resp_error { get; set; }

        public virtual ca_veda_fchk_resp_fchk_report ca_veda_fchk_resp_fchk_report { get; set; }

        public virtual ca_veda_fchk_resp_general_message ca_veda_fchk_resp_general_message { get; set; }

        public virtual ca_veda_fchk_resp_vchk_report ca_veda_fchk_resp_vchk_report { get; set; }

        public virtual ca_veda_fchk_resp_verification_suite_summary ca_veda_fchk_resp_verification_suite_summary { get; set; }
    }
}
