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
    
    public partial class exp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public exp()
        {
            this.exp_detail = new HashSet<exp_detail>();
        }
    
        public int ID { get; set; }
        public int consultant_id { get; set; }
        public Nullable<int> company_id { get; set; }
        public Nullable<int> project_type_id { get; set; }
        public Nullable<int> sow_id { get; set; }
        public Nullable<System.DateTime> start_dt { get; set; }
        public Nullable<System.DateTime> end_dt { get; set; }
        public bool suppressed { get; set; }
        public Nullable<int> domain_id { get; set; }
        public string exp_descr { get; set; }
        public string tags { get; set; }
        public bool approved { get; set; }
        public Nullable<System.DateTime> modified_dtm { get; set; }
        public Nullable<int> modified_user_id { get; set; }
    
        public virtual company company { get; set; }
        public virtual consultant consultant { get; set; }
        public virtual domain domain { get; set; }
        public virtual project_type project_type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<exp_detail> exp_detail { get; set; }
        public virtual sow sow { get; set; }
    }
}
