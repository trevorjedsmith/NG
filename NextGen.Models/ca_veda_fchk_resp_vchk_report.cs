namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_fchk_resp_vchk_report
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ca_veda_fchk_resp_vchk_report()
        {
            ca_veda_fchk_resp_vchk_report_elect_roll_result = new HashSet<ca_veda_fchk_resp_vchk_report_elect_roll_result>();
            ca_veda_fchk_resp_vchk_report_phone_list_result = new HashSet<ca_veda_fchk_resp_vchk_report_phone_list_result>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_veda_fchk_resp_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(5)]
        public string report_summary_code { get; set; }

        [StringLength(100)]
        public string report_summary { get; set; }

        public virtual ca_veda_fchk_resp ca_veda_fchk_resp { get; set; }

        public virtual ca_veda_fchk_resp_vchk_report_drivers_licence_result ca_veda_fchk_resp_vchk_report_drivers_licence_result { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_veda_fchk_resp_vchk_report_elect_roll_result> ca_veda_fchk_resp_vchk_report_elect_roll_result { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_veda_fchk_resp_vchk_report_phone_list_result> ca_veda_fchk_resp_vchk_report_phone_list_result { get; set; }
    }
}
