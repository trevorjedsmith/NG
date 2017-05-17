namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ch_event
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ch_submission_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ch_play_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ch_event_id { get; set; }

        [StringLength(20)]
        public string target_schema_format { get; set; }

        public string translated_xml { get; set; }

        public DateTime? translated_datetime { get; set; }

        public DateTime? sent_datetime { get; set; }

        [StringLength(2048)]
        public string target_endpoint { get; set; }

        public string response_xml { get; set; }

        [StringLength(50)]
        public string target_system_id { get; set; }

        [StringLength(10)]
        public string status { get; set; }

        public string status_description { get; set; }

        public virtual ch_process ch_process { get; set; }
    }
}
