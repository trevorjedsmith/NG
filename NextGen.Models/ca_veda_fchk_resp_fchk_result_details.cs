namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_fchk_resp_fchk_result_details
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ca_veda_fchk_resp_fchk_result_details()
        {
            ca_veda_fchk_resp_fchk_result_details_addr = new HashSet<ca_veda_fchk_resp_fchk_result_details_addr>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_veda_fchk_resp_fchk_report_fchk_result_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(10)]
        public string date_fraud_occurred { get; set; }

        [StringLength(50)]
        public string reporting_subscriber { get; set; }

        [StringLength(50)]
        public string fraud_type { get; set; }

        [StringLength(25)]
        public string employment_status { get; set; }

        [StringLength(15)]
        public string fraud_subject_role { get; set; }

        [StringLength(100)]
        public string comment { get; set; }

        [StringLength(15)]
        public string drivers_licence_number { get; set; }

        [StringLength(2)]
        public string drivers_licence_country_code { get; set; }

        [StringLength(15)]
        public string passport_number { get; set; }

        [StringLength(2)]
        public string passport_country_code { get; set; }

        public virtual ca_veda_fchk_resp_fchk_report_fchk_result ca_veda_fchk_resp_fchk_report_fchk_result { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_veda_fchk_resp_fchk_result_details_addr> ca_veda_fchk_resp_fchk_result_details_addr { get; set; }

        public virtual ca_veda_fchk_resp_fchk_result_details_employer_phone_details ca_veda_fchk_resp_fchk_result_details_employer_phone_details { get; set; }

        public virtual ca_veda_fchk_resp_fchk_result_details_employment ca_veda_fchk_resp_fchk_result_details_employment { get; set; }

        public virtual ca_veda_fchk_resp_fchk_result_details_guarantor_phone_details ca_veda_fchk_resp_fchk_result_details_guarantor_phone_details { get; set; }

        public virtual ca_veda_fchk_resp_fchk_result_details_phone_details ca_veda_fchk_resp_fchk_result_details_phone_details { get; set; }

        public virtual ca_veda_fchk_resp_fchk_result_details_referee_phone_details ca_veda_fchk_resp_fchk_result_details_referee_phone_details { get; set; }

        public virtual ca_veda_fchk_resp_fchk_result_details_second_phone_details ca_veda_fchk_resp_fchk_result_details_second_phone_details { get; set; }
    }
}
