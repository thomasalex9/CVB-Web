namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class thought_leadership
    {
        public int ID { get; set; }

        public int? consultant_id { get; set; }

        [StringLength(220)]
        public string thought_leadership_nm { get; set; }
    }
}
