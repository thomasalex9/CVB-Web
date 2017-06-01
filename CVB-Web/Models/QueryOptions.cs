using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CVB_Web.Models
{
    public enum SortOrder { ASC, DESC };

    public class QueryOptions {

        // properties
        public string SortField { get; set; }
        public SortOrder SortOrder { get; set; }

        // constructor
        public QueryOptions() {
            SortField = "ID";
            SortOrder = SortOrder.ASC;
        }

        public string Sort {
            get {
                return string.Format("{0} {1}", SortField, SortOrder.ToString());
            }
        }
    }

}