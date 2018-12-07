using System.Web;
using System.Web.Optimization;

namespace GoliqDemo
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Content/bootstrap/js/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            //bundles.Add(new ScriptBundle("~/bundles/javascript").Include(
            //            "~/Scripts/JavaScript*"));

            //bundles.Add(new ScriptBundle("~/bundles/javascript").IncludeDirectory(
            //    "~/Scripts", "JavaScript*", true));

            bundles.Add(new StyleBundle("~/bundle/style").Include(
                "~/Content/bootstrap/css/bootstrap.css").Include("~/Content/css/site.css", new CssRewriteUrlTransform()));

            BundleTable.EnableOptimizations = true;
        }
    }
}
