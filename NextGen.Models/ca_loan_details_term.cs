namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_loan_details_term
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_loan_details_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public int? total_term_duration { get; set; }

        public int? total_term_loan_term_units_type { get; set; }

        public bool ed_logically_deleted { get; set; }

        public virtual ad_ca_loan_term_units_type ad_ca_loan_term_units_type { get; set; }

        public virtual ca_loan_details ca_loan_details { get; set; }
    }
}
