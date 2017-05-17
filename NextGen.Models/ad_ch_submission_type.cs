namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_ch_submission_type
    {
        [Key]
        public int ad_ch_submission_type_id { get; set; }

        [Required]
        [StringLength(20)]
        public string product_id { get; set; }

        [Required]
        [StringLength(4)]
        public string system { get; set; }

        public DateTime? inactive_datetime { get; set; }

        [StringLength(20)]
        public string received_schema_format { get; set; }

        [StringLength(20)]
        public string target_schema_format { get; set; }

        [StringLength(2048)]
        public string target_endpoint_url { get; set; }

        [StringLength(100)]
        public string target_endpoint_operation { get; set; }
    }
}
