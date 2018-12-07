using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindDemo.HtmlHelpers
{
    public static class ButtonHelpers
    {
        //<button type="submit" class="btn btn-primary pull-right">Submit</button>
        public static MvcHtmlString Submit(this HtmlHelper helper,string text)
        {
            return Submit(helper, text, null);
        }

        public static MvcHtmlString Submit(this HtmlHelper helper, string text,object htmlAttributes)
        {
            var tagBuilder = new TagBuilder("button")
            {
                InnerHtml = text
            };

            tagBuilder.MergeAttribute("type", "submit");
            tagBuilder.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));

            return MvcHtmlString.Create(tagBuilder.ToString());
        }
    }
}