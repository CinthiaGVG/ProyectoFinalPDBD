using System.Web;
using System.Web.Optimization;

namespace Automotriz
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/js/jquery.min.js",
                        "~/Scripts/js/popper.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/jquery.unobtrusive-ajax.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/js/bootstrap.min.js",
                      "~/Scripts/js/mdb.min.js",
                      "~/Scripts/js/addons/datatables.min.js",
                        "~/Scripts/js/addons/datatables-select.min.js",
                        "~/Scripts/js/addons/datatables-select2.min.js",
                        "~/Scripts/js/addons/datatables2.min.js",
                        "~/Scripts/js/addons/directives.min.js",
                        "~/Scripts/js/addons/flag.min.js",
                        "~/Scripts/js/addons/imagesloaded.pkgd.min.js",
                        "~/Scripts/js/addons/jquery.zmd.hierarchical-display.min.js",
                        "~/Scripts/js/addons/masonry.pkgd.min.js",
                        "~/Scripts/js/addons/rating.min.js",
                        "~/Scripts/jquery-ui.min.js",
                        "~/Scripts/sweetalert2.all.min.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/mdb.min.css",
                      "~/Content/css/style.css",
                      "~/Content/css/addons/datatables.min.css",
                      "~/Content/css/addons/datatables-select.min.css",
                      "~/Content/jquery-ui.min.css"
                      ));
        }
    }
}
