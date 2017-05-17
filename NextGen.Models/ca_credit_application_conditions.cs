namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_credit_application_conditions
    {
        [Key]
        public int ca_credit_application_conditions_id { get; set; }

        public int ca_credit_application_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public bool? ed_created_by_user { get; set; }

        public int? ed_credit_application_condition_type { get; set; }

        [StringLength(500)]
        public string ed_condition_text { get; set; }

        public DateTime? ed_created_date_time { get; set; }

        public DateTime? ed_updated_date_time { get; set; }

        public bool? ed_documentation_required { get; set; }

        public bool? ed_documentation_provided { get; set; }

        public bool? ed_waive { get; set; }

        public bool? ed_subject_to { get; set; }

        public virtual ad_ed_credit_application_condition_type ad_ed_credit_application_condition_type { get; set; }

        public virtual ca_credit_application ca_credit_application { get; set; }
    }
}
