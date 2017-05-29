namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("application")]
    public partial class application
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string application_nm { get; set; }

        public string application_descr { get; set; }

        public int? app_vendor_id { get; set; }

        public int? app_domain_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string formal_nm { get; set; }
    }
}
