using System.Web.Mvc;

namespace Vidly.Utils
{
    public static class Extensions
    {
        /// <summary>
        /// Extension method that returns an HTML class used by Bootstrap framework in order to 
        /// highlight a navigation item when the corresponding page is active.
        /// </summary>
        /// <param name="html"></param>
        /// <param name="controller">Controller name</param>
        /// <param name="action">Action name</param>
        /// <returns>The HTML class "active" if it's true or an empty string otherwise.</returns>
        /// Source: http://www.codingeverything.com/2014/05/mvcbootstrapactivenavbar.html
        public static string IsActive(this HtmlHelper html, string controller, string action)
        {
            var controllerIsActive = !string.IsNullOrWhiteSpace(IsActive(html, controller));
            var routedData = html.ViewContext.RouteData;
            var routeAction = (string)routedData.Values["action"];

            var isActive = routeAction.Equals(action) && controllerIsActive;
            return isActive ? "active" : string.Empty;
        }

        public static string IsActive(this HtmlHelper html, string controller)
        {
            var routedData = html.ViewContext.RouteData;
            var routeController = (string)routedData.Values["controller"];
            return routeController.Equals(controller) ? "active" : string.Empty;
        }
    }
}