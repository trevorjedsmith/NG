namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_person_applicant_contact_mobile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_person_applicant_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(5)]
        public string country_code { get; set; }

        [StringLength(20)]
        public string number { get; set; }

        [StringLength(10)]
        public string overseas_dialing_code { get; set; }

        public int? au_dialing_code { get; set; }

        public virtual ad_ca_au_dialing_code ad_ca_au_dialing_code { get; set; }

        public virtual ca_person_applicant_contact ca_person_applicant_contact { get; set; }
    }
}
