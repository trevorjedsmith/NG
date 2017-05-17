namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_household_living_expense_percent_responsible_owner
    {
        [Key]
        public int ca_household_living_expense_percent_responsible_owner_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public int ca_household_living_expense_id { get; set; }

        [StringLength(36)]
        public string ed_household_living_expense_external_guid { get; set; }

        public int ca_person_applicant_id { get; set; }

        [StringLength(36)]
        public string ed_person_applicant_external_guid { get; set; }

        public decimal? percent_responsible { get; set; }

        public virtual ca_household_living_expense ca_household_living_expense { get; set; }

        public virtual ca_person_applicant ca_person_applicant { get; set; }
    }
}
