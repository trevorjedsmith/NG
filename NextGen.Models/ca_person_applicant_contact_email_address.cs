namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_person_applicant_contact_email_address
    {
        [Key]
        public int ca_person_applicant_contact_email_address_id { get; set; }

        public int ca_person_applicant_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        public int? contact_email_type { get; set; }

        public virtual ad_ca_contact_email_type ad_ca_contact_email_type { get; set; }

        public virtual ca_person_applicant_contact ca_person_applicant_contact { get; set; }
    }
}
