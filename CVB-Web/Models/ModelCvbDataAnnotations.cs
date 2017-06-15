using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CVB_Web.Models
{
    // --------------- app_domain -------------------------------------------
    // apply metadata from this class...
    public class app_domain_MetaData {
        [Display(Name = "Name")]
        public string app_domain_nm;
    }
    // to this class...
    [MetadataType(typeof(app_domain_MetaData))] public partial class app_domain { }

    // --------------- app_vendor -------------------------------------------
    public class app_vendor_MetaData {
        [Display(Name = "Name")]
        public string app_vendor_nm;
    }
    [MetadataType(typeof(app_vendor_MetaData))] public partial class app_vendor { }

    // --------------- title -------------------------------------------
    public class title_MetaData
    {
        [Display(Name = "Title")]
        public string title_nm;
        [Display(Name = "Description")]
        public string title_descr;
    }
    [MetadataType(typeof(title_MetaData))] public partial class title { }
    
    // --------------- company -------------------------------------------
    public class company_MetaData {
        [Display(Name = "Name")]
        public string company_nm;
        [Display(Name = "Location")]
        public string company_location;
        [Display(Name = "Is a Client?")]
        public bool is_client;
        [Display(Name = "Description")]
        public string company_descr;
        [Display(Name = "Short Name")]
        public string company_short_nm;
    }
    [MetadataType(typeof(company_MetaData))] public partial class company { }

    // --------------- consultant -------------------------------------------
    public class consultant_MetaData
    {
        [Display(Name = "Name")]
        public string consultant_nm;

        [Display(Name = "Title")]
        public int title_id;

        [Display(Name = "Initials")]
        public string consultant_initials;

        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public Nullable<System.DateTime> start_dt;

        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public Nullable<System.DateTime> end_dt;

        [Display(Name = "Is Admin")]
        public bool is_admin;

        [Display(Name = "Is Manager")]
        public bool is_manager;
        [Display(Name = "Email")]
        public string email_address;
        [Display(Name = "Noteworthy Intro")]
        public string noteworthy_intro;

        [DataType(DataType.Date)]
        [Display(Name = "Birthday")]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public Nullable<System.DateTime> birth_dt;

        [Display(Name = "Vacation Days")]
        public Nullable<decimal> vacation_available;
    }
    [MetadataType(typeof(consultant_MetaData))] public partial class consultant { }


}