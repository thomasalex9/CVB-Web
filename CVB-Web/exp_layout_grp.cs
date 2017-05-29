namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class exp_layout_grp
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int exp_layout_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int order_nbr { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool suppressed { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(220)]
        public string sort1_val { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(220)]
        public string sort2_val { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(220)]
        public string sort3_val { get; set; }

        [StringLength(220)]
        public string sort1_nm { get; set; }

        [StringLength(220)]
        public string sort2_nm { get; set; }

        [StringLength(220)]
        public string sort3_nm { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(220)]
        public string group_nm { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool show_companies { get; set; }

        [StringLength(220)]
        public string sort_def { get; set; }
    }
}
