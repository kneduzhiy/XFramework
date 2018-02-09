using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using XamarinFramework.Core.Core;

namespace XamarinFramework.iOS
{
    public class XFIosAppDelegate : UIApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            var iosModuleLoader = new XFIosLoader();
            iosModuleLoader.LoadPlatformModule();
            XFramework.Log("FinishedLaunching finished after registering XF", "XF_Internal");

            return true;
        }
    }
}