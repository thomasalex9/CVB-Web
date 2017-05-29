namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class white_paper
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        public int? consultant_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(220)]
        public string white_paper_title { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime white_paper_dt { get; set; }

        [Key]
        [Column(Order = 3)]
        public string description { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool suppressed { get; set; }

        public int? order_nbr { get; set; }
    }
}
