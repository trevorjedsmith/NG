namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_ca_abs_occupation_code
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ad_ca_abs_occupation_code()
        {
            ca_person_applicant_employment_payg = new HashSet<ca_person_applicant_employment_payg>();
            ca_person_applicant_employment_self_employed = new HashSet<ca_person_applicant_employment_self_employed>();
        }

        [Key]
        public int ad_ca_abs_occupation_code_id { get; set; }

        [StringLength(100)]
        public string lending_description { get; set; }

        [StringLength(100)]
        public string lixi_description { get; set; }

        [StringLength(100)]
        public string symtrix_description { get; set; }

        public bool active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_person_applicant_employment_payg> ca_person_applicant_employment_payg { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_person_applicant_employment_self_employed> ca_person_applicant_employment_self_employed { get; set; }
    }
}
