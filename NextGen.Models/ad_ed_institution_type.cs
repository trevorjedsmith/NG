namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_ed_institution_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ad_ed_institution_type()
        {
            ca_case_data = new HashSet<ca_case_data>();
        }

        [Key]
        public int ad_ed_institution_type_id { get; set; }

        [StringLength(10)]
        public string case_prefix { get; set; }

        [StringLength(10)]
        public string code { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_case_data> ca_case_data { get; set; }
    }
}
