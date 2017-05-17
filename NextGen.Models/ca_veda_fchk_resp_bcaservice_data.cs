namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_fchk_resp_bcaservice_data
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_veda_fchk_resp_bcaservice_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public virtual ca_veda_fchk_resp ca_veda_fchk_resp { get; set; }

        public virtual ca_veda_fchk_resp_bcaerror ca_veda_fchk_resp_bcaerror { get; set; }

        public virtual ca_veda_fchk_resp_bcaservice ca_veda_fchk_resp_bcaservice { get; set; }
    }
}
