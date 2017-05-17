namespace NextGen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ch_process
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ch_process()
        {
            ch_event = new HashSet<ch_event>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ch_submission_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ch_play_id { get; set; }

        [StringLength(20)]
        public string play_type { get; set; }

        public DateTime? play_datetime { get; set; }

        [StringLength(256)]
        public string play_userid { get; set; }

        [StringLength(10)]
        public string status { get; set; }

        public string status_description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ch_event> ch_event { get; set; }

        public virtual ch_submission ch_submission { get; set; }
    }
}
