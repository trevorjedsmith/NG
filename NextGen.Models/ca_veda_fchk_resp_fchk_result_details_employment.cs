namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_fchk_resp_fchk_result_details_employment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_veda_fchk_resp_fchk_result_details_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(2)]
        public string country_code { get; set; }

        [StringLength(50)]
        public string employer { get; set; }

        [StringLength(50)]
        public string occupation { get; set; }

        public virtual ca_veda_fchk_resp_fchk_result_details ca_veda_fchk_resp_fchk_result_details { get; set; }
    }
}
