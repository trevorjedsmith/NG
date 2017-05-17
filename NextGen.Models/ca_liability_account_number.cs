namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_liability_account_number
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_liability_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(100)]
        public string account_name { get; set; }

        [StringLength(50)]
        public string account_number { get; set; }

        [StringLength(10)]
        public string bsb { get; set; }

        public int? financial_institution_type { get; set; }

        [StringLength(100)]
        public string other_fi_name { get; set; }

        public virtual ad_ca_financial_institution_type ad_ca_financial_institution_type { get; set; }

        public virtual ca_liability ca_liability { get; set; }
    }
}
