namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_fchk_resp_fchk_result_details_phone_details
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_veda_fchk_resp_fchk_result_details_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(5)]
        public string isd { get; set; }

        [StringLength(5)]
        public string phone_area_code { get; set; }

        [StringLength(20)]
        public string phone_number { get; set; }

        public virtual ca_veda_fchk_resp_fchk_result_details ca_veda_fchk_resp_fchk_result_details { get; set; }
    }
}
