namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_fchk_resp_vchk_report_drivers_licence_result
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_veda_fchk_resp_vchk_report_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(10)]
        public string match_summary { get; set; }

        [StringLength(10)]
        public string number_indicator_match { get; set; }

        [StringLength(10)]
        public string name_indicator_match { get; set; }

        public virtual ca_veda_fchk_resp_vchk_report ca_veda_fchk_resp_vchk_report { get; set; }
    }
}
