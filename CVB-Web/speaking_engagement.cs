namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class speaking_engagement
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        public int? consultant_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(220)]
        public string event_nm { get; set; }

        [StringLength(220)]
        public string event_location { get; set; }

        public DateTime? event_dt { get; set; }

        [StringLength(220)]
        public string event_topic { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int order_nbr { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool suppressed { get; set; }

        public int? event_role { get; set; }
    }
}
