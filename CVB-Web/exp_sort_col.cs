namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class exp_sort_col
    {
        public int ID { get; set; }

        [StringLength(220)]
        public string sort_col_lbl_nm { get; set; }

        [StringLength(220)]
        public string sort_col_table_nm { get; set; }
    }
}
