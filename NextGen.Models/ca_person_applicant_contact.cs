namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_person_applicant_contact
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ca_person_applicant_contact()
        {
            ca_person_applicant_contact_email_address = new HashSet<ca_person_applicant_contact_email_address>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_person_applicant_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public int? preferred_contact_person_type { get; set; }

        public virtual ad_ca_preferred_contact_person_type ad_ca_preferred_contact_person_type { get; set; }

        public virtual ca_person_applicant ca_person_applicant { get; set; }

        public virtual ca_person_applicant_contact_current_address ca_person_applicant_contact_current_address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_person_applicant_contact_email_address> ca_person_applicant_contact_email_address { get; set; }

        public virtual ca_person_applicant_contact_home_phone ca_person_applicant_contact_home_phone { get; set; }

        public virtual ca_person_applicant_contact_mobile ca_person_applicant_contact_mobile { get; set; }

        public virtual ca_person_applicant_contact_previous_address ca_person_applicant_contact_previous_address { get; set; }

        public virtual ca_person_applicant_contact_work_phone ca_person_applicant_contact_work_phone { get; set; }
    }
}
