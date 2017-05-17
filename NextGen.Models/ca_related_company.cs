namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_related_company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ca_related_company()
        {
            ca_person_applicant_employment_payg = new HashSet<ca_person_applicant_employment_payg>();
            ca_person_applicant_employment_self_employed = new HashSet<ca_person_applicant_employment_self_employed>();
            ca_related_company_partner_percent_owned = new HashSet<ca_related_company_partner_percent_owned>();
            ca_related_company_partner_percent_owned1 = new HashSet<ca_related_company_partner_percent_owned>();
        }

        [Key]
        public int ca_related_company_id { get; set; }

        public int ca_credit_application_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(15)]
        public string abn { get; set; }

        public bool? abn_verified { get; set; }

        [StringLength(15)]
        public string acn { get; set; }

        [StringLength(100)]
        public string business_name { get; set; }

        public bool? business_name_same_as_company_name { get; set; }

        public int? business_structure_full_type { get; set; }

        [StringLength(100)]
        public string company_name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_registered { get; set; }

        [Column(TypeName = "date")]
        public DateTime? gst_registered_date { get; set; }

        public short? number_of_partners { get; set; }

        public bool? registered_for_gst { get; set; }

        public int? registered_in_country_code { get; set; }

        public virtual ad_ca_business_structure_full_type ad_ca_business_structure_full_type { get; set; }

        public virtual ad_ca_country_code ad_ca_country_code { get; set; }

        public virtual ca_credit_application ca_credit_application { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_person_applicant_employment_payg> ca_person_applicant_employment_payg { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_person_applicant_employment_self_employed> ca_person_applicant_employment_self_employed { get; set; }

        public virtual ca_related_company_contact ca_related_company_contact { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_related_company_partner_percent_owned> ca_related_company_partner_percent_owned { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_related_company_partner_percent_owned> ca_related_company_partner_percent_owned1 { get; set; }
    }
}
