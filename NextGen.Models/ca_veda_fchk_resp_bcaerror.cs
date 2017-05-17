namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_fchk_resp_bcaerror
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_veda_fchk_resp_bcaservice_data_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(25)]
        public string bcaerror_type { get; set; }

        [StringLength(25)]
        public string bcaerror_code { get; set; }

        [StringLength(255)]
        public string bcaerror_description { get; set; }

        public virtual ca_veda_fchk_resp_bcaservice_data ca_veda_fchk_resp_bcaservice_data { get; set; }
    }
}
