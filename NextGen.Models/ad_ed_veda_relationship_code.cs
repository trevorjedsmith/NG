namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_ed_veda_relationship_code
    {
        [Key]
        public int ad_ed_veda_relationship_code_id { get; set; }

        [StringLength(1)]
        public string code { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        public bool active { get; set; }
    }
}
