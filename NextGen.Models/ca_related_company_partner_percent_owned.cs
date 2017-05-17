namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_related_company_partner_percent_owned
    {
        [Key]
        public int ca_related_company_partner_percent_owned_id { get; set; }

        public int ca_related_company_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public int? partner_type { get; set; }

        public decimal? percent_owned { get; set; }

        public int? partner_ca_person_applicant_id { get; set; }

        [StringLength(36)]
        public string ed_partner_ca_person_applicant_external_guid { get; set; }

        public int? partner_ca_company_applicant_id { get; set; }

        [StringLength(36)]
        public string ed_partner_ca_company_applicant_external_guid { get; set; }

        public int? partner_ca_trust_applicant_id { get; set; }

        [StringLength(36)]
        public string ed_partner_ca_trust_applicant_external_guid { get; set; }

        public int? partner_ca_related_person_id { get; set; }

        [StringLength(36)]
        public string ed_partner_ca_related_person_external_guid { get; set; }

        public int? partner_ca_related_company_id { get; set; }

        [StringLength(36)]
        public string ed_partner_ca_related_company_external_guid { get; set; }

        public virtual ad_ca_partner_type ad_ca_partner_type { get; set; }

        public virtual ca_company_applicant ca_company_applicant { get; set; }

        public virtual ca_person_applicant ca_person_applicant { get; set; }

        public virtual ca_related_company ca_related_company { get; set; }

        public virtual ca_related_company ca_related_company1 { get; set; }

        public virtual ca_related_person ca_related_person { get; set; }

        public virtual ca_trust_applicant ca_trust_applicant { get; set; }
    }
}
