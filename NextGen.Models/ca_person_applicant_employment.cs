namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_person_applicant_employment
    {
        [Key]
        public int ca_person_applicant_employment_id { get; set; }

        public int ca_person_applicant_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public int? ed_employment_type { get; set; }

        public virtual ad_ed_employment_type ad_ed_employment_type { get; set; }

        public virtual ca_person_applicant ca_person_applicant { get; set; }

        public virtual ca_person_applicant_employment_not_employed ca_person_applicant_employment_not_employed { get; set; }

        public virtual ca_person_applicant_employment_payg ca_person_applicant_employment_payg { get; set; }

        public virtual ca_person_applicant_employment_self_employed ca_person_applicant_employment_self_employed { get; set; }
    }
}
