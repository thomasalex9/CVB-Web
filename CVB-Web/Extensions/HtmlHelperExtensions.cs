using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using System.Web.Mvc.MvcHtmlString;
using CVB_Web.Models;

namespace CVB_Web.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString BuildSortableLink(this HtmlHelper htmlHelper, 
            string fieldName, string  actionName, string sortField, QueryOptions queryOptions)
        {
            var urlHelper = new UrlHelper(htmlHelper.ViewContext.RequestContext);
            var isCurrentSortField = (queryOptions.SortField == sortField);

            MvcHtmlString s = new MvcHtmlString ( 
                string.Format("<a href=\"{0}\">{1} {2}</a>",
                    urlHelper.Action(actionName, 
                        new { SortField = sortField,
                              SortOrder = (isCurrentSortField && queryOptions.SortOrder == SortOrder.ASC ?
                                              SortOrder.DESC : SortOrder.ASC) } ),
                    fieldName,
                    BuildSortIcon(isCurrentSortField,queryOptions)));

            return s;
        }

        private static string BuildSortIcon(bool isCurrentSortField, QueryOptions queryOptions) {
            string sortIcon = "sort";
            if (isCurrentSortField) {
                sortIcon += "-by-alphabet";
                if (queryOptions.SortOrder == SortOrder.DESC)
                    sortIcon += "-alt";
            }
            return string.Format("<span class=\"{0} {1}{2}\"></span>", "glyphicon", "glyphicon-", sortIcon);
        }
    }
}