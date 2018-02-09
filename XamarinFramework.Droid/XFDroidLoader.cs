using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinFramework.Core.Core;
using XamarinFramework.Core.Core.Interfaces;
using XamarinFramework.Core.Services.Interfaces;
using XamarinFramework.Droid.Services;
using XamarinFramework.Droid.Services.StoredPreferences;

namespace XamarinFramework.Droid
{
    public class XFDroidLoader : IXFLoader
    {
        public void LoadPlatformModule()
        {
            XFramework.Log("Starting to load platform modules", "XF_Internal");

            XFramework.RegisterService<IXFPersistedStoredPreferences>(new XFPersistedStoredPreferences());
            XFramework.RegisterService<IXFAlertService>(new XFAlertService());
        }
    }
}