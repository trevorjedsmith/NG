namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_fchk_resp_vchk_report_phone_list_result_addr_indicator
    {
        [Key]
        public int ca_veda_fchk_resp_vchk_report_phone_list_result_addr_indicator_id { get; set; }

        public int ca_veda_fchk_resp_vchk_report_phone_list_result_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(20)]
        public string address_indicator_type { get; set; }

        [StringLength(10)]
        public string address_indicator_match { get; set; }

        [StringLength(10)]
        public string unit_number_indicator_match { get; set; }

        [StringLength(10)]
        public string street_number_indicator_match { get; set; }

        [StringLength(10)]
        public string property_indicator_match { get; set; }

        [StringLength(10)]
        public string street_name_indicator_match { get; set; }

        [StringLength(10)]
        public string street_type_indicator_match { get; set; }

        [StringLength(10)]
        public string suburb_indicator_match { get; set; }

        [StringLength(10)]
        public string state_indicator_match { get; set; }

        [StringLength(10)]
        public string postcode_indicator_match { get; set; }

        public virtual ca_veda_fchk_resp_vchk_report_phone_list_result ca_veda_fchk_resp_vchk_report_phone_list_result { get; set; }
    }
}
