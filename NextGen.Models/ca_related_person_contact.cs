namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_related_person_contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_related_person_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        public int? contact_email_type { get; set; }

        public int? preferred_contact_person_type { get; set; }

        public int? address_ca_address_id { get; set; }

        [StringLength(36)]
        public string ed_address_ca_address_external_guid { get; set; }

        public virtual ad_ca_contact_email_type ad_ca_contact_email_type { get; set; }

        public virtual ad_ca_preferred_contact_person_type ad_ca_preferred_contact_person_type { get; set; }

        public virtual ca_address ca_address { get; set; }

        public virtual ca_related_person ca_related_person { get; set; }

        public virtual ca_related_person_contact_home_phone ca_related_person_contact_home_phone { get; set; }

        public virtual ca_related_person_contact_mobile ca_related_person_contact_mobile { get; set; }

        public virtual ca_related_person_contact_work_phone ca_related_person_contact_work_phone { get; set; }
    }
}
