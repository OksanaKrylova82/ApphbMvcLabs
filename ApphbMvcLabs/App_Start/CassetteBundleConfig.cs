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
                    "~/Content/Site.less"
                });

            bundles.Add<ScriptBundle>(
                "~/Scripts",
                new[]
                {
                    "~/Scripts/jquery-2.1.0.js",
                    "~/Scripts/jquery.validate.js",
                    "~/Scripts/jquery.validate.unobtrusive.js",

                    "~/Scripts/Common/Site.coffee"
                });
        }
    }
}