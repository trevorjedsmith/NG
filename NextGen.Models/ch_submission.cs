namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ch_submission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ch_submission()
        {
            ch_process = new HashSet<ch_process>();
        }

        [Key]
        public int ch_submission_id { get; set; }

        [StringLength(50)]
        public string application_reference { get; set; }

        [StringLength(20)]
        public string received_schema_format { get; set; }

        public string received_xml { get; set; }

        [StringLength(4)]
        public string system { get; set; }

        public DateTime? received_datetime { get; set; }

        [StringLength(16)]
        public string ip_address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ch_process> ch_process { get; set; }
    }
}
