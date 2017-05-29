namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class consultant_biography
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int consultant_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public string bio_txt { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool show { get; set; }

        [StringLength(220)]
        public string bio_descr { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(3)]
        public string show_RIC { get; set; }
    }
}
