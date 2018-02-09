using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using XamarinFramework.Core.Core;
using XamarinFramework.Core.Core.Interfaces;
using XamarinFramework.Core.Services.Interfaces;
using XamarinFramework.iOS.Services.StoredPreferences;
using XamarinFramework.iOS.Services;

namespace XamarinFramework.iOS
{
    public class XFIosLoader : IXFLoader
    {
        public void LoadPlatformModule()
        {
            XFramework.RegisterService<IXFPersistedStoredPreferences>(new XFPersistedStoredPreferences());
            XFramework.RegisterService<IXFAlertService>(new XFAlertService());
        }
    }
}