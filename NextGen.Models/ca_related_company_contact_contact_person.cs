namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_related_company_contact_contact_person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_related_company_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(100)]
        public string role { get; set; }

        public int? contact_person_ca_related_person_id { get; set; }

        [StringLength(36)]
        public string ed_contact_person_ca_related_person_external_guid { get; set; }

        public virtual ca_related_company_contact ca_related_company_contact { get; set; }

        public virtual ca_related_person ca_related_person { get; set; }
    }
}
