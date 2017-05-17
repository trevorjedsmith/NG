namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_related_person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ca_related_person()
        {
            ca_related_company_contact_contact_person = new HashSet<ca_related_company_contact_contact_person>();
            ca_related_company_partner_percent_owned = new HashSet<ca_related_company_partner_percent_owned>();
        }

        [Key]
        public int ca_related_person_id { get; set; }

        public int ca_credit_application_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(50)]
        public string person_name_first_name { get; set; }

        [StringLength(50)]
        public string person_name_surname { get; set; }

        public int? person_name_name_title_type { get; set; }

        public virtual ad_ca_name_title_type ad_ca_name_title_type { get; set; }

        public virtual ca_credit_application ca_credit_application { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_related_company_contact_contact_person> ca_related_company_contact_contact_person { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_related_company_partner_percent_owned> ca_related_company_partner_percent_owned { get; set; }

        public virtual ca_related_person_contact ca_related_person_contact { get; set; }
    }
}
