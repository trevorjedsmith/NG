namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_liability_account_performance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_liability_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public short? ed_no_of_overdraws_ltd { get; set; }

        public short? ed_days_overdrawn_ytd { get; set; }

        public short? ed_no_of_delinquencies_ltd_30 { get; set; }

        public short? ed_no_of_delinquencies_ltd_60 { get; set; }

        public short? ed_no_of_delinquencies_ltd_90 { get; set; }

        public short? ed_no_of_delinquencies_ltd_120 { get; set; }

        public short? ed_no_of_delinquencies_ltd_150 { get; set; }

        public short? ed_no_of_delinquencies_ltd_180 { get; set; }

        public virtual ca_liability ca_liability { get; set; }
    }
}
