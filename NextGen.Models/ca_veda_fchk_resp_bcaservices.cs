namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_fchk_resp_bcaservices
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_veda_fchk_resp_bcamessage_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public virtual ca_veda_fchk_resp_bcamessage ca_veda_fchk_resp_bcamessage { get; set; }

        public virtual ca_veda_fchk_resp_bcaservice ca_veda_fchk_resp_bcaservice { get; set; }
    }
}
