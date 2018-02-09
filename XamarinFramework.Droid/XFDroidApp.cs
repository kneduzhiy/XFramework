
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

namespace XamarinFramework.Droid
{
    public class XFDroidApp : Application
    {
        public XFDroidApp() : base()
        {
        }

        public XFDroidApp(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public static Activity CurrentTopActivity { get; set; }

        public override void OnCreate()
        {
            base.OnCreate();
            new XFDroidLoader().LoadPlatformModule();
        }
    }
}