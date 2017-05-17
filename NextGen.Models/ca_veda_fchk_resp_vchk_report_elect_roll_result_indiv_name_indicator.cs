namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_fchk_resp_vchk_report_elect_roll_result_indiv_name_indicator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_veda_fchk_resp_vchk_report_elect_roll_result_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(10)]
        public string individual_name_indicator_match { get; set; }

        [StringLength(10)]
        public string first_given_name_indicator_match { get; set; }

        [StringLength(10)]
        public string first_given_name_indicator_match_initial { get; set; }

        [StringLength(10)]
        public string other_given_name_indicator_match { get; set; }

        [StringLength(10)]
        public string other_given_name_indicator_match_initial { get; set; }

        [StringLength(10)]
        public string family_name_indicator_match { get; set; }

        public virtual ca_veda_fchk_resp_vchk_report_elect_roll_result ca_veda_fchk_resp_vchk_report_elect_roll_result { get; set; }
    }
}
