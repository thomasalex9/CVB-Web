namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sow")]
    public partial class sow
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string sow_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int company_id { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(220)]
        public string project_nm { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int project_type_id { get; set; }

        public string description { get; set; }

        public DateTime? start_dt { get; set; }

        public DateTime? end_dt { get; set; }

        public int? master_sow { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool meradia_sow { get; set; }

        public int? domain_id { get; set; }

        public DateTime? intro_dt { get; set; }

        public int? intro_con { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool active_sow { get; set; }
    }
}
