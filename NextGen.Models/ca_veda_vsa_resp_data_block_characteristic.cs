namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ca_veda_vsa_resp_data_block_characteristic
    {
        [Key]
        public int ca_veda_vsa_resp_data_block_characteristic_id { get; set; }

        public int ca_veda_vsa_resp_summary_data_data_block_id { get; set; }

        [StringLength(36)]
        public string ed_external_guid { get; set; }

        public bool ed_logically_deleted { get; set; }

        [StringLength(6)]
        public string id { get; set; }

        [StringLength(5)]
        public string key_characteristic { get; set; }

        [StringLength(40)]
        public string variable_name { get; set; }

        [StringLength(150)]
        public string description { get; set; }

        [StringLength(20)]
        public string characteristic_value { get; set; }

        [StringLength(20)]
        public string unit { get; set; }

        [StringLength(20)]
        public string data_level { get; set; }

        [StringLength(1)]
        public string code { get; set; }

        public virtual ca_veda_vsa_resp_summary_data_data_block ca_veda_vsa_resp_summary_data_data_block { get; set; }
    }
}
