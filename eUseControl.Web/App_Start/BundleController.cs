using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace eUseControl.Web.App_Start


{
     public static class BundleConfig
     {
          public static void RegisterBundles(BundleCollection bundles)
          {
               //Style
               bundles.Add(new StyleBundle("~/bundles/open-iconic-bootstrap/css").Include("~/Content/open-iconic-bootstrap.min.css"));
               bundles.Add(new StyleBundle("~/bundles/animate/css").Include("~/Content/animate.css"));

               bundles.Add(new StyleBundle("~/bundles/owl.carousel/css").Include("~/Content/owl.carousel.min.css"));
               bundles.Add(new StyleBundle("~/bundles/owl.theme.default/css").Include("~/Content/owl.theme.default.min.css"));
               bundles.Add(new StyleBundle("~/bundles/magnific-popup/css").Include("~/Content/magnific-popup.css"));

               bundles.Add(new StyleBundle("~/bundles/aos/css").Include("~/Content/aos.css"));

               bundles.Add(new StyleBundle("~/bundles/ionicons/css").Include("~/Content/ionicons.min.css"));

               bundles.Add(new StyleBundle("~/bundles/bootstrap-datepicker/css").Include("~/Content/bootstrap-datepicker.css"));
               bundles.Add(new StyleBundle("~/bundles/jquery.timepicker/css").Include("~/Content/jquery.timepicker.css"));

               bundles.Add(new StyleBundle("~/bundles/flaticon/css").Include("~/Content/flaticon.css"));
               bundles.Add(new StyleBundle("~/bundles/icomoon/css").Include("~/Content/icomoon.css"));
               bundles.Add(new StyleBundle("~/bundles/style/css").Include( "~/Content/style.css", new CssRewriteUrlTransform()));



               //Script
               bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include("~/Scripts/jquery.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/jquery-migrate-3.0.1/js").Include("~/Scripts/jquery-migrate-3.0.1.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/popper/js").Include("~/Scripts/popper.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include("~/Scripts/bootstrap.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/jquery.easing.1.3p/js").Include("~/Scripts/jquery.easing.1.3.js"));
               bundles.Add(new ScriptBundle("~/bundles/jquery.waypoints/js").Include("~/Scripts/jquery.waypoints.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/jquery.stellar/js").Include("~/Scripts/jquery.stellar.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/owl.carousel/js").Include("~/Scripts/owl.carousel.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/jquery.magnific-popup/js").Include("~/Scripts/jquery.magnific-popup.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/aos/js").Include("~/Scripts/aos.js"));
               bundles.Add(new ScriptBundle("~/bundles/jquery.animateNumber/js").Include("~/Scripts/jquery.animateNumber.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/bootstrap-datepicker/js").Include("~/Scripts/bootstrap-datepicker.js"));
               bundles.Add(new ScriptBundle("~/bundles/jquery.timepicker/js").Include("~/Scripts/jquery.timepicker.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/scrollax/js").Include("~/Scripts/scrollax.min.js"));
               bundles.Add(new ScriptBundle("~/bundles/google-map/js").Include("~/Scripts/google-map.js"));
               bundles.Add(new ScriptBundle("~/bundles/main/js").Include("~/Scripts/main.js"));






          }
     }
}