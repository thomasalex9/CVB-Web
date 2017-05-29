namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("publication")]
    public partial class publication
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        public int? consultant_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(220)]
        public string article_title { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(220)]
        public string publication_nm { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(220)]
        public string volume_info { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int order_nbr { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool suppressed { get; set; }
    }
}
