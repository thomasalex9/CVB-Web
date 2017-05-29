namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("audit")]
    public partial class audit
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(220)]
        public string table_nm { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int record_id { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime time_stamp { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(220)]
        public string tran_type { get; set; }

        [StringLength(220)]
        public string field_nm { get; set; }

        public int? consultant_id { get; set; }
    }
}
