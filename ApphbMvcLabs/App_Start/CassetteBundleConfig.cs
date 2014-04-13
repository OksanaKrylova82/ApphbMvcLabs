using Cassette;
using Cassette.Scripts;
using Cassette.Stylesheets;

namespace ApphbMvcLabs
{
    public class CassetteBundleConfig : IConfiguration<BundleCollection>
    {
        public void Configure(BundleCollection bundles)
        {
            bundles.Add<StylesheetBundle>("~/Content");

            bundles.Add<ScriptBundle>(
                "~/Scripts",
                new[]
                {
                    "~/Scripts/jquery-1.10.2.js",
                    "~/Scripts/jquery.validate.js",
                    "~/Scripts/jquery.validate.unobtrusive.js"
                });
        }
    }
}