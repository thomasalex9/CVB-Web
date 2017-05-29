namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class timeslip_role
    {
        public int ID { get; set; }

        [StringLength(220)]
        public string slip_role_nm { get; set; }
    }
}
