namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_fchk_resp_vchk_report_phone_list_result
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ca_veda_fchk_resp_vchk_report_phone_list_result()
        {
            ca_veda_fchk_resp_vchk_report_phone_list_result_addr_indicator = new HashSet<ca_veda_fchk_resp_vchk_report_phone_list_result_addr_indicator>();
        }

        [Key]
        public int ca_veda_fchk_resp_vchk_report_phone_list_result_id { get; set; }

        public int ca_veda_fchk_resp_vchk_report_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(10)]
        public string match_summary { get; set; }

        [StringLength(20)]
        public string phone_listing_type { get; set; }

        [StringLength(10)]
        public string phone_indicator_match { get; set; }

        [StringLength(10)]
        public string family_name_indicator_match { get; set; }

        [StringLength(10)]
        public string initials_indicator_match { get; set; }

        public virtual ca_veda_fchk_resp_vchk_report ca_veda_fchk_resp_vchk_report { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_veda_fchk_resp_vchk_report_phone_list_result_addr_indicator> ca_veda_fchk_resp_vchk_report_phone_list_result_addr_indicator { get; set; }
    }
}
