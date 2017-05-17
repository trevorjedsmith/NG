namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_loan_details_loan_score_card_result
    {
        [Key]
        public int ca_loan_details_loan_score_card_result_id { get; set; }

        public int ca_loan_details_loan_score_card_id { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public short? score { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public virtual ca_loan_details_loan_score_card ca_loan_details_loan_score_card { get; set; }
    }
}
