using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace System.Web.Mvc
{

    public static class CaptchaHtmlHelperExtensions
    {
        public static MvcHtmlString Captcha(this HtmlHelper helper, string id, string title, object htmlAttributes)
        {
            TagBuilder tagBuilder = new TagBuilder("img");
            tagBuilder.GenerateId(id);
            tagBuilder.MergeAttribute("title", title);
            tagBuilder.MergeAttributes(new RouteValueDictionary(htmlAttributes));
            return MvcHtmlString.Create(tagBuilder.ToString(TagRenderMode.SelfClosing));

            //var writer = new HtmlTextWriter(new StringWriter());
            //writer.AddAttribute(HtmlTextWriterAttribute.Alt, "验证码");
            ////writer.AddAttribute(HtmlTextWriterAttribute.Src, url);
            //writer.RenderBeginTag(HtmlTextWriterTag.Img);
            //writer.RenderEndTag();
            //return writer.InnerWriter.ToString();

            //return helper.ActionLink("", "Index", "Home");
        }      
    }
}
