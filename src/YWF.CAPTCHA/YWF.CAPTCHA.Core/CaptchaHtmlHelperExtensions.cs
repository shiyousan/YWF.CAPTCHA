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
        /// <summary>
        /// 根据当前url节点判断是否返回激活active样式
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="localPath"></param>
        /// <param name="activeNode"></param>
        /// <returns></returns>
        public static MvcHtmlString SetNavbarActiveClass(this HtmlHelper helper, string localPath, params string[] activeNode)
        {
            if (string.IsNullOrWhiteSpace(localPath))
            {
                return new MvcHtmlString(string.Empty);
            }
            var nodeArr = localPath.Split('/');
            var currentNode = nodeArr.Length > 1 ? nodeArr[1] : string.Empty;
            string result = activeNode.Contains(currentNode) ? "active" : string.Empty;
            return new MvcHtmlString(result);
        }
    }
}
