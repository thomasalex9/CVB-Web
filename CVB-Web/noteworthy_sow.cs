namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class noteworthy_sow
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        public int? consultant_id { get; set; }

        public int? sow_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int order_nbr { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool suppressed { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(220)]
        public string project_nm { get; set; }
    }
}
