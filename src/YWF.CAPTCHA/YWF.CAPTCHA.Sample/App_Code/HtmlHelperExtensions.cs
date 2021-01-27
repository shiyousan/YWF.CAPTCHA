using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace YWF.CAPTCHA.Sample.App_Code
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString Captcha(this HtmlHelper helper)
        {
            string result = "";
            return new MvcHtmlString(result);
        }
        //public static string Label(this HtmlHelper helper, string id, string title, object htmlAttributes)
        //{
        //    TagBuilder builder = new TagBuilder("label");
        //    builder.GenerateId(id);
        //    builder.MergeAttribute("title", title);
        //    builder.MergeAttributes(new System.Web.Routing.RouteValueDictionary(htmlAttributes));

        //    return builder.ToString(TagRenderMode.SelfClosing);
        //}
    }
}