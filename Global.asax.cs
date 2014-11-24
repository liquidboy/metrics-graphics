using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Security;
using System.Web.SessionState;

namespace metrics_graphics
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //pulling list of js files to bunndle from make.py
            var bundle = new ScriptBundle("~/metricsgraphics").Include(new string[] {
                "~/src/common/data_graphic.js",
                "~/src/common/bootstrap_tooltip_popover.js",
                "~/src/common/chart_title.js",
                "~/src/common/y_axis.js",
                "~/src/common/x_axis.js",
                "~/src/common/init.js",
                "~/src/common/markers.js",
                "~/src/layout/bootstrap_dropdown.js",
                "~/src/layout/button.js",
                "~/src/charts/line.js",
                "~/src/charts/histogram.js",
                "~/src/charts/point.js",
                "~/src/charts/bar.js",
                "~/src/charts/table.js",
                "~/src/charts/missing.js",
                "~/src/misc/process.js",
                "~/src/misc/smoothers.js",
                "~/src/misc/utility.js",
                "~/src/misc/error.js",
            }); //.IncludeDirectory("~/src", "*.js", true) <== does not work
            BundleTable.Bundles.Add(bundle);
            
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}