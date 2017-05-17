namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_person_applicant_proof_of_identity
    {
        [Key]
        public int ca_person_applicant_proof_of_identity_id { get; set; }

        public int ca_person_applicant_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(100)]
        public string document_number { get; set; }

        public int? document_type { get; set; }

        public virtual ad_ca_document_type ad_ca_document_type { get; set; }

        public virtual ca_person_applicant ca_person_applicant { get; set; }
    }
}
