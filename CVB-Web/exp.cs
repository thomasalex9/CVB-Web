namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("exp")]
    public partial class exp
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int consultant_id { get; set; }

        public int? company_id { get; set; }

        public int? project_type_id { get; set; }

        public int? sow_id { get; set; }

        public DateTime? start_dt { get; set; }

        public DateTime? end_dt { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool suppressed { get; set; }

        public int? domain_id { get; set; }

        public string exp_descr { get; set; }

        [StringLength(220)]
        public string tags { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool approved { get; set; }

        public DateTime? modified_dtm { get; set; }

        public int? modified_user_id { get; set; }
    }
}
