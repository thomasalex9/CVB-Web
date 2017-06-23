using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CVB_Web.Models
{
    public enum SortOrder { ASC, DESC };

    public class QueryOptions {

        // properties
        public string SortField { get; set; }
        public SortOrder SortOrder { get; set; }
        public string Search { get; set; }
        public string FilterField { get; set; }
        public string FilterValue { get; set; } 
        public SelectList FilterList;

        // constructor
        public QueryOptions() {
            SortField = "ID";
            SortOrder = SortOrder.ASC;
            Search = "";
            FilterField = "";
            FilterValue = "";
        }

        public string Sort {
            // return a string suitable for use with a LINQ query
            get {
                return string.Format("{0} {1}", SortField, SortOrder.ToString());
            }
        }
    }

}