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
    
    public partial class consultant_biography
    {
        public int ID { get; set; }
        public int consultant_id { get; set; }
        public string bio_txt { get; set; }
        public bool show { get; set; }
        public string bio_descr { get; set; }
        public string show_RIC { get; set; }
    
        public virtual consultant consultant { get; set; }
    }
}