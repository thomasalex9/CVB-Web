namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class exp_detail
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        public int? exp_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int order_nbr { get; set; }

        public string detail_txt { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool suppressed { get; set; }

        public int? role_id { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool approved { get; set; }

        public DateTime? modified_dtm { get; set; }

        public int? modified_user_id { get; set; }

        [StringLength(15)]
        public string record_status { get; set; }

        [StringLength(220)]
        public string admin_approved_dtm { get; set; }

        public int? admin_approved_user_id { get; set; }

        public DateTime? mgr_approved_dtm { get; set; }

        public int? mgr_approved_user_id { get; set; }
    }
}
