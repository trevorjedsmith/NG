namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_address
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ca_address()
        {
            ca_non_real_estate_asset_motor_vehicle = new HashSet<ca_non_real_estate_asset_motor_vehicle>();
            ca_person_applicant_contact_current_address = new HashSet<ca_person_applicant_contact_current_address>();
            ca_person_applicant_contact_current_address1 = new HashSet<ca_person_applicant_contact_current_address>();
            ca_person_applicant_contact_previous_address = new HashSet<ca_person_applicant_contact_previous_address>();
            ca_real_estate_asset = new HashSet<ca_real_estate_asset>();
            ca_related_company_contact = new HashSet<ca_related_company_contact>();
            ca_related_person_contact = new HashSet<ca_related_person_contact>();
        }

        [Key]
        public int ca_address_id { get; set; }

        public int ca_credit_application_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(100)]
        public string ed_care_of_details { get; set; }

        [StringLength(10)]
        public string au_post_code { get; set; }

        [StringLength(255)]
        public string gnaf_id { get; set; }

        public decimal? latitude { get; set; }

        [StringLength(255)]
        public string lga_name { get; set; }

        public decimal? longitude { get; set; }

        [StringLength(10)]
        public string overseas_post_code { get; set; }

        [StringLength(50)]
        public string overseas_state { get; set; }

        [StringLength(50)]
        public string suburb { get; set; }

        public bool? tba_address { get; set; }

        public int? au_state_type { get; set; }

        public int? country_code { get; set; }

        public int? address_type { get; set; }

        [StringLength(255)]
        public string ed_formatted_address_line_1 { get; set; }

        [StringLength(255)]
        public string ed_formatted_address_line_2 { get; set; }

        [StringLength(255)]
        public string ed_formatted_address_line_3 { get; set; }

        public virtual ad_ca_address_type ad_ca_address_type { get; set; }

        public virtual ad_ca_au_state_type ad_ca_au_state_type { get; set; }

        public virtual ad_ca_country_code ad_ca_country_code { get; set; }

        public virtual ca_credit_application ca_credit_application { get; set; }

        public virtual ca_address_dx_box ca_address_dx_box { get; set; }

        public virtual ca_address_non_standard ca_address_non_standard { get; set; }

        public virtual ca_address_po_box ca_address_po_box { get; set; }

        public virtual ca_address_standard ca_address_standard { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_non_real_estate_asset_motor_vehicle> ca_non_real_estate_asset_motor_vehicle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_person_applicant_contact_current_address> ca_person_applicant_contact_current_address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_person_applicant_contact_current_address> ca_person_applicant_contact_current_address1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_person_applicant_contact_previous_address> ca_person_applicant_contact_previous_address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_real_estate_asset> ca_real_estate_asset { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_related_company_contact> ca_related_company_contact { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ca_related_person_contact> ca_related_person_contact { get; set; }
    }
}
