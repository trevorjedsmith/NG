namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_ed_lender_purpose_code
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ad_ed_lender_purpose_code()
        {
            ca_loan_details_lending_purpose = new HashSet<ca_loan_details_lending_purpose>();
        }

        [Key]
        public int ad_ed_lender_purpose_code_id { get; set; }

        [StringLength(100)]
        public string lending_description { get; set; }

        public bool active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_loan_details_lending_purpose> ca_loan_details_lending_purpose { get; set; }
    }
}
