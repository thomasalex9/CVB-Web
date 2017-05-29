namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class holiday
    {
        public int ID { get; set; }

        [StringLength(220)]
        public string holiday_nm { get; set; }

        public DateTime? holiday_dt { get; set; }
    }
}
