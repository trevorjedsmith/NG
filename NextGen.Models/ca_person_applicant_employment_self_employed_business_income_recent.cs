namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_person_applicant_employment_self_employed_business_income_recent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_person_applicant_employment_self_employed_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public decimal? profit_before_tax { get; set; }

        public decimal? ed_profit_after_tax { get; set; }

        public decimal? ed_percent_for_affordability { get; set; }

        public virtual ca_person_applicant_employment_self_employed ca_person_applicant_employment_self_employed { get; set; }
    }
}
