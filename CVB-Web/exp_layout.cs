namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class exp_layout
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        public int? consultant_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sort_col1_id { get; set; }

        public int? sort_col2_id { get; set; }

        public int? sort_col3_id { get; set; }

        [StringLength(220)]
        public string user_nm { get; set; }

        public DateTime? create_dt { get; set; }

        [StringLength(220)]
        public string descr { get; set; }

        [StringLength(220)]
        public string layout_nm { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool sub_sect_tl_se { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool sub_sect_tl_wp { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool sub_sect_tl_pub { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool sect_ne { get; set; }
    }
}
