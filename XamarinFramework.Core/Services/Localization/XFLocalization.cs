using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinFramework.Core.Properties;

namespace XamarinFramework.Core.Services
{
    public class XFLocalization
    {
        public static string GetLocalizedString(string resKey)
        {
            return XFStrings.ResourceManager.GetString(resKey);
        }

        public static string GetFormattedLocalizedString(string resKey, params object[] format)
        {
            return string.Format(XFStrings.ResourceManager.GetString(resKey), format);
        }
    }
}
