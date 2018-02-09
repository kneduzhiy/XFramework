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
using XamarinFramework.Droid;

namespace XFTestApp.Droid
{
    [Application(Debuggable = true)]
    public class App : XFDroidApp
    {
        public App()
        {
        }

        public App(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {

        }
    }
}