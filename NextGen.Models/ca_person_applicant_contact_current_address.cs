namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_person_applicant_contact_current_address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_person_applicant_id { get; set; }

        public int? residential_address_ca_address_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        public int? housing_status_type { get; set; }

        [Column(TypeName = "date")]
        public DateTime? start_date { get; set; }

        public short? ed_years_resident { get; set; }

        [StringLength(36)]
        public string ed_residential_address_ca_address_external_guid { get; set; }

        public int? mailing_address_ca_address_id { get; set; }

        [StringLength(36)]
        public string ed_mailing_address_ca_address_external_guid { get; set; }

        public virtual ad_ca_housing_status_type ad_ca_housing_status_type { get; set; }

        public virtual ca_address ca_address { get; set; }

        public virtual ca_address ca_address1 { get; set; }

        public virtual ca_person_applicant_contact ca_person_applicant_contact { get; set; }
    }
}
