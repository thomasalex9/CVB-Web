namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class timeslip_task
    {
        public int ID { get; set; }

        [StringLength(40)]
        public string slip_task_nm { get; set; }
    }
}
