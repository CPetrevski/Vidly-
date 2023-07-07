using System.Web;
using System.Web.Optimization;

namespace Vidly
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new Bundle("~/bundles/bootbox").Include(
                      "~/Scripts/bootbox.js"));

            bundles.Add(new Bundle("~/bundles/respond").Include(
                      "~/Scripts/respond.js"));

            bundles.Add(new Bundle("~/bundles/datatables").Include(
                      "~/Scripts/DataTables/jquery.dataTables.js"));

            bundles.Add(new Bundle("~/bundles/bootstrapdata").Include(
                      "~/Scripts/DataTables/dataTables.bootstrap4.js"));

            bundles.Add(new Bundle("~/bundles/typeahead").Include(
                      "~/scripts/typeahead.bundle.js"));
            
            bundles.Add(new Bundle("~/bundles/toastr").Include(
                      "~/scripts/toastr.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-super.css",
                      "~/Content/bootstrap-theme.css",
                      "~/Content/DataTables/css/datatables.bootstrap4.css",
                      "~/Content/typeahead.css",
                      "~/Content/toastr.css",

                      "~/Content/site.css"));
        }
    }
}
