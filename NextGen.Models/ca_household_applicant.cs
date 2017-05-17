namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_household_applicant
    {
        [Key]
        public int ca_household_applicant_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public int ca_household_id { get; set; }

        [StringLength(36)]
        public string ed_household_external_guid { get; set; }

        public int ca_person_applicant_id { get; set; }

        [StringLength(36)]
        public string ed_person_applicant_external_guid { get; set; }

        public virtual ca_household ca_household { get; set; }

        public virtual ca_person_applicant ca_person_applicant { get; set; }
    }
}
