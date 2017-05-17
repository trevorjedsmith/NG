namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_ed_institution_branch_type
    {
        [Key]
        public int ad_ed_institution_branch_type_id { get; set; }

        [StringLength(10)]
        public string code { get; set; }

        [StringLength(10)]
        public string bsb { get; set; }

        [StringLength(150)]
        public string description { get; set; }

        [StringLength(100)]
        public string care_of_details { get; set; }

        [StringLength(50)]
        public string box_type { get; set; }

        [StringLength(10)]
        public string box_number { get; set; }

        [StringLength(100)]
        public string building_name { get; set; }

        [StringLength(10)]
        public string level { get; set; }

        [StringLength(10)]
        public string unit { get; set; }

        [StringLength(10)]
        public string street_number { get; set; }

        [StringLength(100)]
        public string street_name { get; set; }

        [StringLength(50)]
        public string street_suffix_type { get; set; }

        [StringLength(50)]
        public string street_type { get; set; }

        [StringLength(50)]
        public string suburb { get; set; }

        [StringLength(10)]
        public string state { get; set; }

        [StringLength(10)]
        public string post_code { get; set; }

        [StringLength(50)]
        public string country { get; set; }

        [StringLength(25)]
        public string phone_number { get; set; }

        [StringLength(25)]
        public string fax_number { get; set; }

        public bool active { get; set; }
    }
}
