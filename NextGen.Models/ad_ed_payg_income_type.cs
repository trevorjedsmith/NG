namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_ed_payg_income_type
    {
        [Key]
        public int ad_ed_payg_income_type_id { get; set; }

        [StringLength(100)]
        public string lending_description { get; set; }

        public decimal? percent_for_affordability { get; set; }

        public bool active { get; set; }
    }
}
