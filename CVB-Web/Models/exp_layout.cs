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
    
    public partial class exp_layout
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public exp_layout()
        {
            this.exp_layout_grp = new HashSet<exp_layout_grp>();
        }
    
        public int ID { get; set; }
        public Nullable<int> consultant_id { get; set; }
        public int sort_col1_id { get; set; }
        public Nullable<int> sort_col2_id { get; set; }
        public Nullable<int> sort_col3_id { get; set; }
        public string user_nm { get; set; }
        public Nullable<System.DateTime> create_dt { get; set; }
        public string descr { get; set; }
        public string layout_nm { get; set; }
        public bool sub_sect_tl_se { get; set; }
        public bool sub_sect_tl_wp { get; set; }
        public bool sub_sect_tl_pub { get; set; }
        public bool sect_ne { get; set; }
    
        public virtual consultant consultant { get; set; }
        public virtual exp_sort_col exp_sort_col { get; set; }
        public virtual exp_sort_col exp_sort_col1 { get; set; }
        public virtual exp_sort_col exp_sort_col2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<exp_layout_grp> exp_layout_grp { get; set; }
    }
}
