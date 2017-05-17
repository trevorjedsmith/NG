namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_ed_veda_permission_type
    {
        [Key]
        public int ad_ed_veda_permission_type_id { get; set; }

        [StringLength(2)]
        public string code { get; set; }

        [StringLength(1)]
        public string data_level { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        public bool active { get; set; }
    }
}
