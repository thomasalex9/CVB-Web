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
    
    public partial class consultant_education
    {
        public int ID { get; set; }
        public int consultant_id { get; set; }
        public string degree_nm { get; set; }
        public string institution_nm { get; set; }
        public Nullable<System.DateTime> acquired_dt { get; set; }
        public Nullable<int> order_nbr { get; set; }
    
        public virtual consultant consultant { get; set; }
    }
}
