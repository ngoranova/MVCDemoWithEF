using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcDemo.Helpers
{
    public static class HtmlHelperExtensions
    {
        //Can be used to setup action when clicking on cell image
        public static MvcHtmlString ActionImage(this HtmlHelper html, string action, string controllerName, string imagePath, string alt, object routeValues = null)
        {
            var url = new UrlHelper(html.ViewContext.RequestContext);

            // build the <img> tag
            var imgBuilder = new TagBuilder("img");
            imgBuilder.MergeAttribute("src", url.Content(imagePath));
            imgBuilder.MergeAttribute("alt", alt);
            string imgHtml = imgBuilder.ToString(TagRenderMode.SelfClosing);

            // build the <a> tag
            var anchorBuilder = new TagBuilder("a");
            anchorBuilder.MergeAttribute("href", url.Action(action, controllerName, routeValues));

            anchorBuilder.InnerHtml = imgHtml; // include the <img> tag inside
            string anchorHtml = anchorBuilder.ToString(TagRenderMode.Normal);

            return MvcHtmlString.Create(anchorHtml);
        }

        public static MvcHtmlString ActionImage(this HtmlHelper html, string action, string controllerName, string imagePath, string alt, object routeValues = null, object htmlAttributes = null)
        {
            var url = new UrlHelper(html.ViewContext.RequestContext);

            var attributes = AnonymousObjectToKeyValue(htmlAttributes);

            // build the <img> tag
            var imgBuilder = new TagBuilder("img");
            imgBuilder.MergeAttribute("src", url.Content(imagePath));
            imgBuilder.MergeAttribute("alt", alt);
            string imgHtml = imgBuilder.ToString(TagRenderMode.SelfClosing);

            // build the <a> tag
            var anchorBuilder = new TagBuilder("a");
            anchorBuilder.MergeAttribute("href", url.Action(action, controllerName, routeValues));

            anchorBuilder.MergeAttributes(attributes, true);
            anchorBuilder.InnerHtml = imgHtml; // include the <img> tag inside
            string anchorHtml = anchorBuilder.ToString(TagRenderMode.Normal);

            return MvcHtmlString.Create(anchorHtml);
        }

        private static Dictionary<string, object> AnonymousObjectToKeyValue(object anonymousObject)
        {
            var dictionary = new Dictionary<string, object>();

            if (anonymousObject == null) return dictionary;

            foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(anonymousObject))
            {
                dictionary.Add(propertyDescriptor.Name, propertyDescriptor.GetValue(anonymousObject));
            }

            return dictionary;
        }

    }
}