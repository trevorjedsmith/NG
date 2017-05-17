namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_loan_details_loan_auto_decision_result
    {
        [Key]
        public int ca_loan_details_loan_auto_decision_result_id { get; set; }

        public int ca_loan_details_loan_auto_decision_id { get; set; }

        public int? ed_auto_decision_status { get; set; }

        public bool? ed_pass { get; set; }

        [StringLength(255)]
        public string ed_description { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public virtual ad_ca_status_name_application_instructions_type ad_ca_status_name_application_instructions_type { get; set; }

        public virtual ca_loan_details_loan_auto_decision ca_loan_details_loan_auto_decision { get; set; }
    }
}
