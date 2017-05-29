namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("company")]
    public partial class company
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string company_nm { get; set; }

        [StringLength(200)]
        public string company_location { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool is_client { get; set; }

        [StringLength(220)]
        public string company_descr { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(40)]
        public string company_short_nm { get; set; }
    }
}
