using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using Celerik.NetCore.Util;
using Microsoft.Extensions.Localization;

namespace {{namespace}}.Services
{
    [SuppressMessage("Design", "CA1052:Static holder types should be Static or NotInheritable", Justification = "This class is instantiable by the String Localizer Factory")]
    [ExcludeFromCodeCoverage]
    public class {{short-namespace}}Resources
    {
        private static IStringLocalizer _localizer;

        private static IStringLocalizer Localizer
        {
            get
            {
                if (_localizer == null && UtilResources.Factory != null)
                    _localizer = UtilResources.Factory.Create(typeof({{short-namespace}}Resources));

                return _localizer;
            }
        }

        public static string Get(string name)
            => Localizer?[name].Value ?? name;

        public static string Get(string name, params object[] arguments)
            => Localizer?[name, arguments].Value ??
                string.Format(CultureInfo.InvariantCulture, name, arguments);
    }
}
