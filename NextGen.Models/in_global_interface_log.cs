namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class in_global_interface_log
    {
        [Key]
        public int in_global_interface_log_id { get; set; }

        [StringLength(16)]
        public string version { get; set; }

        public DateTime create_date { get; set; }

        public DateTime effective_date { get; set; }

        [Required]
        [StringLength(256)]
        public string server { get; set; }

        [Required]
        [StringLength(256)]
        public string client { get; set; }

        [Required]
        [StringLength(256)]
        public string interface_name { get; set; }

        [Required]
        [StringLength(36)]
        public string request_guid { get; set; }

        [StringLength(256)]
        public string reference_guid { get; set; }

        public byte? status { get; set; }

        public byte? log_type { get; set; }

        public string log { get; set; }
    }
}
