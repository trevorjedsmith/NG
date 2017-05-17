namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_fchk_resp_fchk_result_summary
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_veda_fchk_resp_fchk_report_fchk_result_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(10)]
        public string fraudcheck_phone_indicator_match_with { get; set; }

        [StringLength(10)]
        public string fraudcheck_employer_phone_indicator_match_with { get; set; }

        [StringLength(10)]
        public string fraudcheck_guarantor_phone_indicator_match_with { get; set; }

        [StringLength(10)]
        public string fraudcheck_referee_phone_indicator_match_with { get; set; }

        [StringLength(10)]
        public string fraudcheck_address_indicator_match { get; set; }

        [StringLength(10)]
        public string fraudcheck_employer_indicator_match { get; set; }

        [StringLength(10)]
        public string fraudcheck_drivers_licence_indicator_match { get; set; }

        [StringLength(10)]
        public string fraudcheck_passport_indicator_match { get; set; }

        [StringLength(10)]
        public string fraudcheck_second_phone_indicator_match_with { get; set; }

        public virtual ca_veda_fchk_resp_fchk_report_fchk_result ca_veda_fchk_resp_fchk_report_fchk_result { get; set; }
    }
}
