namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class exp_layout_grp_dtl
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int exp_layout_grp_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int exp_detail_id { get; set; }

        public int? order_nbr { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool suppressed { get; set; }

        public string detail_txt { get; set; }

        [StringLength(220)]
        public string user_nm { get; set; }
    }
}
