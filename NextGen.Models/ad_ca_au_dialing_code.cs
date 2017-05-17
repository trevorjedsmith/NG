namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_ca_au_dialing_code
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ad_ca_au_dialing_code()
        {
            ca_person_applicant_contact_home_phone = new HashSet<ca_person_applicant_contact_home_phone>();
            ca_person_applicant_contact_mobile = new HashSet<ca_person_applicant_contact_mobile>();
            ca_person_applicant_contact_work_phone = new HashSet<ca_person_applicant_contact_work_phone>();
            ca_related_company_contact_office_fax = new HashSet<ca_related_company_contact_office_fax>();
            ca_related_company_contact_office_phone = new HashSet<ca_related_company_contact_office_phone>();
            ca_related_person_contact_home_phone = new HashSet<ca_related_person_contact_home_phone>();
            ca_related_person_contact_mobile = new HashSet<ca_related_person_contact_mobile>();
            ca_related_person_contact_work_phone = new HashSet<ca_related_person_contact_work_phone>();
        }

        [Key]
        public int ad_ca_au_dialing_code_id { get; set; }

        [StringLength(100)]
        public string lending_description { get; set; }

        [StringLength(100)]
        public string lixi_description { get; set; }

        public bool active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_person_applicant_contact_home_phone> ca_person_applicant_contact_home_phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_person_applicant_contact_mobile> ca_person_applicant_contact_mobile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_person_applicant_contact_work_phone> ca_person_applicant_contact_work_phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_related_company_contact_office_fax> ca_related_company_contact_office_fax { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_related_company_contact_office_phone> ca_related_company_contact_office_phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_related_person_contact_home_phone> ca_related_person_contact_home_phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_related_person_contact_mobile> ca_related_person_contact_mobile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_related_person_contact_work_phone> ca_related_person_contact_work_phone { get; set; }
    }
}
