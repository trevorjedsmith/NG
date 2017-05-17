namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_ed_credit_document_type
    {
        [Key]
        public int ad_ed_credit_document_type_id { get; set; }

        [StringLength(100)]
        public string lending_description { get; set; }

        [StringLength(36)]
        public string lending_code { get; set; }

        [StringLength(100)]
        public string core_description { get; set; }

        [StringLength(36)]
        public string core_code { get; set; }

        public bool active { get; set; }
    }
}
