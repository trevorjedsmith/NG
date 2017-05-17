namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_case_data
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_credit_application_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public int? ed_case_status_type { get; set; }

        public DateTime? ed_created_date_time { get; set; }

        public int? ed_caseid { get; set; }

        [StringLength(50)]
        public string ed_case_number { get; set; }

        public int? ed_case_creator_iduser { get; set; }

        [StringLength(50)]
        public string ed_case_creator_coreid { get; set; }

        [StringLength(50)]
        public string ed_external_creator_coreid { get; set; }

        public int? ed_institution_type { get; set; }

        public virtual ad_ed_case_status_type ad_ed_case_status_type { get; set; }

        public virtual ad_ed_institution_type ad_ed_institution_type { get; set; }

        public virtual ca_credit_application ca_credit_application { get; set; }
    }
}
