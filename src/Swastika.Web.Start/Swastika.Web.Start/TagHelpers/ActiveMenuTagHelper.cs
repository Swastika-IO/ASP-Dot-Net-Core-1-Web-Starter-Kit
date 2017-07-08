using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swastika.Web.Start.TagHelpers
{
    [HtmlTargetElement(Attributes = "is-active-menu")]
    public class ActiveMenuTagHelper : TagHelper
    {
        private IDictionary<string, string> _routeValues;
        
        /// <summary>The name of the controller.</summary>
        /// <remarks>Must be <c>null</c> if <see cref="P:Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper.Route" /> is non-<c>null</c>.</remarks>
        [HtmlAttributeName("asp-controllers")]
        public string Controllers { get; set; }
        
        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.AspNetCore.Mvc.Rendering.ViewContext" /> for the current request.
        /// </summary>
        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);

            if (ShouldBeActive())
            {
                MakeActive(output);
            }

            output.Attributes.RemoveAll("is-active-menu");
        }

        private bool ShouldBeActive()
        {
            bool rtn = false;
            string currentController = ViewContext.RouteData.Values["Controller"].ToString();

            //string currentAction = ViewContext.RouteData.Values["Action"].ToString();

            if (!string.IsNullOrWhiteSpace(Controllers))
            {
                foreach (string controller in Controllers.Split(','))
                {
                    if (currentController.ToLower() == controller.ToLower()) {
                        rtn = true;
                        break;
                    }
                }

            }

            return rtn;
        }

        private void MakeActive(TagHelperOutput output)
        {
            var classAttr = output.Attributes.FirstOrDefault(a => a.Name == "class");
            if (classAttr == null)
            {
                classAttr = new TagHelperAttribute("class", "active");
                output.Attributes.Add(classAttr);
            }
            else if (classAttr.Value == null || classAttr.Value.ToString().IndexOf("active") < 0)
            {
                output.Attributes.SetAttribute("class", classAttr.Value == null
                    ? "active"
                    : classAttr.Value.ToString() + " active");
            }
        }
    }
}
