namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_rule_execution_log
    {
        [Key]
        public int ca_rule_execution_log_id { get; set; }

        public int ca_credit_application_id { get; set; }

        [Required]
        [StringLength(50)]
        public string ed_session_guid { get; set; }

        [Required]
        [StringLength(50)]
        public string ed_request_guid { get; set; }

        [Required]
        [StringLength(50)]
        public string ed_rule_name { get; set; }

        public DateTime ed_request_start { get; set; }

        public DateTime ed_request_end { get; set; }

        public string ed_html_log { get; set; }

        public string ed_xml_deserialized_log { get; set; }

        public virtual ca_credit_application ca_credit_application { get; set; }
    }
}
