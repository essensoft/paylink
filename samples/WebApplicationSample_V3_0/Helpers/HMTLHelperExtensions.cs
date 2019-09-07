using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplicationSample_V3_0.Helpers
{
    public static class HtmlHelpers
    {
        public static string IsActive(this IHtmlHelper html, string controller = null, string action = null, string activeClass = "active")
        {
            var actualAction = (string)html.ViewContext.RouteData.Values["action"];
            var actualController = (string)html.ViewContext.RouteData.Values["controller"];

            if (string.IsNullOrEmpty(controller))
            {
                controller = actualController;
            }

            if (string.IsNullOrEmpty(action))
            {
                action = actualAction;
            }

            return controller == actualController && action == actualAction ? activeClass : string.Empty;
        }
    }
}
