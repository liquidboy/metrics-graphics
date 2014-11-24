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
            var bundle = new ScriptBundle("~/metricsgraphics")
                .IncludeDirectory("~/src/common", "*.js")
                .IncludeDirectory("~/src/layout", "*.js")
                .IncludeDirectory("~/src/charts", "*.js")
                .IncludeDirectory("~/src/misc", "*.js");
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