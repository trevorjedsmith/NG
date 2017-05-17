namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_loan_details_percent_owned_owner
    {
        [Key]
        public int ca_loan_details_percent_owned_owner_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public int ca_loan_details_id { get; set; }

        [StringLength(36)]
        public string ed_loan_details_external_guid { get; set; }

        public int ca_person_applicant_id { get; set; }

        [StringLength(36)]
        public string ed_person_applicant_external_guid { get; set; }

        public decimal? percent_owned { get; set; }

        public virtual ca_loan_details ca_loan_details { get; set; }

        public virtual ca_person_applicant ca_person_applicant { get; set; }
    }
}
