﻿using System.Web;
using System.Web.Optimization;

namespace MVCReview
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                        "~/Scripts/DataTables/jquery.dataTables.min.js",
                        "~/Scripts/DataTables/dataTables.bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/datatables").Include(
                        "~/Content/DataTables/css/dataTables.bootstrap.css"));

            bundles.Add(new ScriptBundle("~/bundles/grid").Include(
                "~/Scripts/i18n/grid.locale-en.js",
                        "~/Scripts/jquery.jqGrid.min.js",
                        "~/Scripts/jquery-ui-1.10.0.min.js"));

            bundles.Add(new StyleBundle("~/Content/grid").Include(
                        "~/Content/jquery.jqGrid/ui.jqgrid.css",
                        "~/Content/themes/base/jquery.jqGrid/jquery-ui.css",
                        "~/Content/themes/base/jquery.jqGrid/jquery.ui.theme.css",
                        "~/Content/themes/base/jquery.jqGrid/jquery.ui.theme.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
