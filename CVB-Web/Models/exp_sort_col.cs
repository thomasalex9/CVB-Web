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
    
    public partial class exp_sort_col
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public exp_sort_col()
        {
            this.exp_layout = new HashSet<exp_layout>();
            this.exp_layout1 = new HashSet<exp_layout>();
            this.exp_layout2 = new HashSet<exp_layout>();
        }
    
        public int ID { get; set; }
        public string sort_col_lbl_nm { get; set; }
        public string sort_col_table_nm { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<exp_layout> exp_layout { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<exp_layout> exp_layout1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<exp_layout> exp_layout2 { get; set; }
    }
}
