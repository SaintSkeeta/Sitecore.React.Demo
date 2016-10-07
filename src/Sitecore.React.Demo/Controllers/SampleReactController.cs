using Sitecore.React.Mvc.Controllers;
using Sitecore.Web.UI.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sitecore.React.Demo.Controllers
{
    public class SampleReactController : Controller
    {
        // GET: SampleReact
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SampleReactRendering()
        {
            var data = new
            {
                Title = FieldRenderer.Render(Sitecore.Context.Item, "Title"),
                Text = FieldRenderer.Render(Sitecore.Context.Item, "Text")
            };

            return this.React("~/views/SampleReact/SampleReactRendering.jsx", data);
        }
    }
}