namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("timeslip")]
    public partial class timeslip
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int consultant_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sow_id { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime slip_start_dt { get; set; }

        public int? slip_phase_nm { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(220)]
        public string slip_location { get; set; }

        [Key]
        [Column(Order = 5)]
        public string slip_desc { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime slip_end_dt { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(220)]
        public string slip_status { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal slip_time { get; set; }

        [StringLength(220)]
        public string slip_task_nm { get; set; }

        [StringLength(220)]
        public string slip_bill_status { get; set; }
    }
}
