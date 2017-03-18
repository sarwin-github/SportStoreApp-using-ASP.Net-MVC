using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace SportsStore.WebUI.HtmlHelpers
{
    public static class BeginFormHorizontal
    {
        public static MvcForm BeginHorizontalForm(this HtmlHelper helper)
        {
            return helper.BeginForm(null, null, FormMethod.Post, new { @class = "form-horizontal col-md-12" });
        }
    }
}