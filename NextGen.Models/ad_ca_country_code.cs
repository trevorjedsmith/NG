namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_ca_country_code
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ad_ca_country_code()
        {
            ca_address = new HashSet<ca_address>();
            ca_other_income = new HashSet<ca_other_income>();
            ca_person_applicant = new HashSet<ca_person_applicant>();
            ca_related_company = new HashSet<ca_related_company>();
        }

        [Key]
        public int ad_ca_country_code_id { get; set; }

        [StringLength(100)]
        public string lending_description { get; set; }

        [StringLength(100)]
        public string lixi_description { get; set; }

        [StringLength(100)]
        public string symtrix_description { get; set; }

        [StringLength(100)]
        public string core_description { get; set; }

        [StringLength(36)]
        public string core_code { get; set; }

        public bool active { get; set; }

        [StringLength(36)]
        public string veda_score_apply_code { get; set; }

        [StringLength(36)]
        public string veda_fraud_check_code { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_address> ca_address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_other_income> ca_other_income { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_person_applicant> ca_person_applicant { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_related_company> ca_related_company { get; set; }
    }
}
