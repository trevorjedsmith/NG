namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_loan_details_proposed_repayment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_loan_details_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public decimal? regular_repayment_amount { get; set; }

        public int? regular_repayment_frequency_full_type { get; set; }

        public bool ed_logically_deleted { get; set; }

        public virtual ad_ca_frequency_full_type ad_ca_frequency_full_type { get; set; }

        public virtual ca_loan_details ca_loan_details { get; set; }
    }
}
