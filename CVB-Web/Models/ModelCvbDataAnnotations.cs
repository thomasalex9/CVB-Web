using System.ComponentModel.DataAnnotations;

namespace CVB_Web.Models
{
    // apply metadata from this class...
    public class app_domain_MetaData {
        [Display(Name = "Name")]
        public string app_domain_nm;
    }
    // to this class...
    [MetadataType(typeof(app_domain_MetaData))] public partial class app_domain { }

    public class app_vendor_MetaData {
        [Display(Name = "Name")]
        public string app_vendor_nm;
    }
    [MetadataType(typeof(app_vendor_MetaData))] public partial class app_vendor { }

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
}