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
    
    public partial class exp_detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public exp_detail()
        {
            this.exp_layout_grp_dtl = new HashSet<exp_layout_grp_dtl>();
        }
    
        public int ID { get; set; }
        public Nullable<int> exp_id { get; set; }
        public int order_nbr { get; set; }
        public string detail_txt { get; set; }
        public bool suppressed { get; set; }
        public Nullable<int> role_id { get; set; }
        public bool approved { get; set; }
        public Nullable<System.DateTime> modified_dtm { get; set; }
        public Nullable<int> modified_user_id { get; set; }
        public string record_status { get; set; }
        public string admin_approved_dtm { get; set; }
        public Nullable<int> admin_approved_user_id { get; set; }
        public Nullable<System.DateTime> mgr_approved_dtm { get; set; }
        public Nullable<int> mgr_approved_user_id { get; set; }
    
        public virtual exp exp { get; set; }
        public virtual role role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<exp_layout_grp_dtl> exp_layout_grp_dtl { get; set; }
    }
}
