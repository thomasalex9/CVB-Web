namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class experience_detail
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        public int? experience_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public string detail_txt { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int role_id { get; set; }

        [StringLength(220)]
        public string tags { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int order_nbr { get; set; }
    }
}
