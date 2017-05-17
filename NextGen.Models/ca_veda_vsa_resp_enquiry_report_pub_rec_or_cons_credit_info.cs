namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_vsa_resp_enquiry_report_pub_rec_or_cons_credit_info
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ca_veda_vsa_resp_enquiry_report_pub_rec_or_cons_credit_info()
        {
            ca_veda_vsa_resp_pub_rec_or_cons_credit_info_pers_insolvency = new HashSet<ca_veda_vsa_resp_pub_rec_or_cons_credit_info_pers_insolvency>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_veda_vsa_resp_product_data_enquiry_report_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public virtual ca_veda_vsa_resp_product_data_enquiry_report ca_veda_vsa_resp_product_data_enquiry_report { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_veda_vsa_resp_pub_rec_or_cons_credit_info_pers_insolvency> ca_veda_vsa_resp_pub_rec_or_cons_credit_info_pers_insolvency { get; set; }
    }
}
