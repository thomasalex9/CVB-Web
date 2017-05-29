namespace CVB_Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class company_info
    {
        public int ID { get; set; }

        [StringLength(220)]
        public string company_nm { get; set; }

        [StringLength(220)]
        public string owner_nm { get; set; }

        [StringLength(220)]
        public string owner_title { get; set; }

        [StringLength(220)]
        public string app_owner { get; set; }

        [StringLength(220)]
        public string app_owner_title { get; set; }

        [StringLength(220)]
        public string street_address { get; set; }

        [StringLength(220)]
        public string city { get; set; }

        [StringLength(220)]
        public string state { get; set; }

        [StringLength(220)]
        public string phone_number { get; set; }

        [StringLength(220)]
        public string fax_number { get; set; }

        public string website { get; set; }

        public string home_page_greeting { get; set; }

        [StringLength(220)]
        public string zip_code { get; set; }

        public string sharepoint_site { get; set; }

        public int? meradia_globe { get; set; }

        public int? sow_id { get; set; }
    }
}
