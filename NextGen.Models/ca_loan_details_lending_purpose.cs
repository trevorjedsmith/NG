namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_loan_details_lending_purpose
    {
        [Key]
        public int ca_loan_details_lending_purpose_id { get; set; }

        public int ca_loan_details_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public int? abs_lending_purpose_code { get; set; }

        public int? lender_code { get; set; }

        public virtual ad_ca_abs_lending_purpose_code ad_ca_abs_lending_purpose_code { get; set; }

        public virtual ad_ed_lender_purpose_code ad_ed_lender_purpose_code { get; set; }

        public virtual ca_loan_details ca_loan_details { get; set; }
    }
}
