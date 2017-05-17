namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_fchk_resp_error
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_veda_fchk_resp_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(20)]
        public string error_type { get; set; }

        [StringLength(5)]
        public string error_type_code { get; set; }

        [StringLength(30)]
        public string input_container { get; set; }

        [StringLength(100)]
        public string error_description { get; set; }

        [StringLength(10)]
        public string error_description_code { get; set; }

        public virtual ca_veda_fchk_resp ca_veda_fchk_resp { get; set; }
    }
}
