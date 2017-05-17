namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_address_dx_box
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_address_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(255)]
        public string exchange { get; set; }

        [StringLength(255)]
        public string number { get; set; }

        [StringLength(255)]
        public string provider { get; set; }

        public virtual ca_address ca_address { get; set; }
    }
}
