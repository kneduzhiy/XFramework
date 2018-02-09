using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinFramework.Core.Services
{
    public static class XFLocalizationStringExtensions
    {
        public static string Localize(this string inputString)
        {
            return XFLocalization.GetLocalizedString(inputString);
        }

        public static string LocalizeFormatted(this string inputString, params object[] format)
        {
            return XFLocalization.GetFormattedLocalizedString(inputString, format);
        }
    }
}
