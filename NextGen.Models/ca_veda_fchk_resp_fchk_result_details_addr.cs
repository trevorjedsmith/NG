namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_fchk_resp_fchk_result_details_addr
    {
        [Key]
        public int ca_veda_fchk_resp_fchk_result_details_addr_id { get; set; }

        public int ca_veda_fchk_resp_fchk_result_details_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(5)]
        public string unit_number { get; set; }

        [StringLength(10)]
        public string street_number { get; set; }

        [StringLength(25)]
        public string property { get; set; }

        [StringLength(25)]
        public string street_name { get; set; }

        [StringLength(5)]
        public string street_type_code { get; set; }

        [StringLength(25)]
        public string suburb { get; set; }

        [StringLength(25)]
        public string city { get; set; }

        [StringLength(3)]
        public string state { get; set; }

        [StringLength(4)]
        public string postcode { get; set; }

        [StringLength(2)]
        public string country_code { get; set; }

        public virtual ca_veda_fchk_resp_fchk_result_details ca_veda_fchk_resp_fchk_result_details { get; set; }
    }
}
