namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_non_real_estate_asset_motor_vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ca_non_real_estate_asset_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(50)]
        public string additional_id_type { get; set; }

        [StringLength(50)]
        public string additional_id_value { get; set; }

        public short? age { get; set; }

        [StringLength(50)]
        public string badge { get; set; }

        public int? vehicle_body_type { get; set; }

        [StringLength(50)]
        public string colour { get; set; }

        public int? condition_type { get; set; }

        [StringLength(255)]
        public string condition_description { get; set; }

        public short? cylinders { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public short? doors { get; set; }

        public decimal? effective_life { get; set; }

        public decimal? engine_capacity { get; set; }

        public int? engine_hours_total { get; set; }

        [StringLength(50)]
        public string engineid { get; set; }

        [StringLength(50)]
        public string fuel_type { get; set; }

        public int? good_to_be_used_address_ca_address_id { get; set; }

        [StringLength(36)]
        public string ed_good_to_be_used_address_ca_address_external_guid { get; set; }

        public int? kilometres { get; set; }

        public int? vehicle_make_type { get; set; }

        [StringLength(50)]
        public string model { get; set; }

        [StringLength(255)]
        public string options { get; set; }

        [StringLength(255)]
        public string other_information { get; set; }

        public short? quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? registration_expiry_date { get; set; }

        [StringLength(50)]
        public string registration_number { get; set; }

        [StringLength(50)]
        public string serial_number { get; set; }

        [StringLength(50)]
        public string series { get; set; }

        [StringLength(50)]
        public string transmission { get; set; }

        public int? vehicle_type { get; set; }

        [StringLength(50)]
        public string variant { get; set; }

        public short? year { get; set; }

        public int? ed_registration_plate_type { get; set; }

        public int? registration_state_type { get; set; }

        public virtual ad_ca_condition_type ad_ca_condition_type { get; set; }

        public virtual ad_ca_registration_state_type ad_ca_registration_state_type { get; set; }

        public virtual ad_ca_vehicle_type ad_ca_vehicle_type { get; set; }

        public virtual ad_ed_registration_plate_type ad_ed_registration_plate_type { get; set; }

        public virtual ad_ed_vehicle_body_type ad_ed_vehicle_body_type { get; set; }

        public virtual ad_ed_vehicle_make_type ad_ed_vehicle_make_type { get; set; }

        public virtual ca_address ca_address { get; set; }

        public virtual ca_non_real_estate_asset ca_non_real_estate_asset { get; set; }
    }
}
