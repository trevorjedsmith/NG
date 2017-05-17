namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_related_company_contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_related_company_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        public string web_address { get; set; }

        public int? address_ca_address_id { get; set; }

        [StringLength(36)]
        public string ed_address_ca_address_external_guid { get; set; }

        public virtual ca_address ca_address { get; set; }

        public virtual ca_related_company ca_related_company { get; set; }

        public virtual ca_related_company_contact_contact_person ca_related_company_contact_contact_person { get; set; }

        public virtual ca_related_company_contact_office_fax ca_related_company_contact_office_fax { get; set; }

        public virtual ca_related_company_contact_office_phone ca_related_company_contact_office_phone { get; set; }
    }
}
