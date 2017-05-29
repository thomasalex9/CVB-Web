namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("proficiency")]
    public partial class proficiency
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(220)]
        public string app_proficiency { get; set; }

        [StringLength(220)]
        public string skill_proficiency { get; set; }

        public string descr { get; set; }
    }
}
