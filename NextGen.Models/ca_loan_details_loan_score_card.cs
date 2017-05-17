namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_loan_details_loan_score_card
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ca_loan_details_loan_score_card()
        {
            ca_loan_details_loan_score_card_result = new HashSet<ca_loan_details_loan_score_card_result>();
        }

        [Key]
        public int ca_loan_details_loan_score_card_id { get; set; }

        public int ca_loan_details_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public DateTime? ed_execution_datetime { get; set; }

        public virtual ca_loan_details ca_loan_details { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_loan_details_loan_score_card_result> ca_loan_details_loan_score_card_result { get; set; }
    }
}
