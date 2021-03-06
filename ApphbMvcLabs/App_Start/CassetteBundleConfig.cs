using Cassette;
using Cassette.Scripts;
using Cassette.Stylesheets;

namespace ApphbMvcLabs
{
    public class CassetteBundleConfig : IConfiguration<BundleCollection>
    {
        public void Configure(BundleCollection bundles)
        {
            bundles.Add<StylesheetBundle>(
                "~/Content",
                new[]
                {
                    "~/Content/bootstrap.css",
                    "~/Content/bootstrap-theme.css",
                    "~/Content/blog.css",
                    "~/Content/font-awesome.css",
                    "~/Content/Site.less"
                });

            bundles.Add<ScriptBundle>(
                "~/Scripts",
                new[]
                {
                    "~/Scripts/jquery-2.1.0.js",
                    "~/Scripts/jquery.validate.js",
                    "~/Scripts/jquery.validate.unobtrusive.js",
                    "~/Scripts/bootstrap.js",
                    "~/Scripts/Common/Site.coffee"
                });

            bundles.Add<ScriptBundle>(
                "~/Scripts/ltIE9",
                new[]
                {
                    "~/Scripts/respond.js",
                    "~/Scripts/html5shiv.js"
                },
                x => x.PageLocation = "ltIE9");
        }
    }
}