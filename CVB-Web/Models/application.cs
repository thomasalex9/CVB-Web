//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CVB_Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class application
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public application()
        {
            this.consultant_application = new HashSet<consultant_application>();
        }
    
        public int ID { get; set; }
        public string application_nm { get; set; }
        public string application_descr { get; set; }
        public Nullable<int> app_vendor_id { get; set; }
        public Nullable<int> app_domain_id { get; set; }
        public string formal_nm { get; set; }
    
        public virtual app_domain app_domain { get; set; }
        public virtual app_vendor app_vendor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<consultant_application> consultant_application { get; set; }
    }
}