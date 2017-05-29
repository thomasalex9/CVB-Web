namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("consultant")]
    public partial class consultant
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string consultant_nm { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int title_id { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string consultant_initials { get; set; }

        public DateTime? start_dt { get; set; }

        public DateTime? end_dt { get; set; }

        public string image_url { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool is_admin { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool is_manager { get; set; }

        [StringLength(220)]
        public string email_address { get; set; }

        [StringLength(220)]
        public string noteworthy_intro { get; set; }

        public DateTime? birth_dt { get; set; }

        public int? headshot { get; set; }

        public decimal? vacation_available { get; set; }
    }
}
