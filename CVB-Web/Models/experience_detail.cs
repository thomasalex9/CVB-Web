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
    
    public partial class experience_detail
    {
        public int ID { get; set; }
        public Nullable<int> experience_id { get; set; }
        public string detail_txt { get; set; }
        public int role_id { get; set; }
        public string tags { get; set; }
        public int order_nbr { get; set; }
    
        public virtual experience experience { get; set; }
        public virtual role role { get; set; }
    }
}
