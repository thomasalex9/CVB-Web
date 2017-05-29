namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class consultant_education
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
        [StringLength(220)]
        public string degree_nm { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(220)]
        public string institution_nm { get; set; }

        public DateTime? acquired_dt { get; set; }

        public int? order_nbr { get; set; }
    }
}
