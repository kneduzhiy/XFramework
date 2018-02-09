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

namespace XamarinFramework.Droid.Core.ViewModels
{
    public class XFViewModelActivity<TViewModel> : Activity where TViewModel : XFViewModel
    {
        public static TViewModel ViewModel => (TViewModel)Activator.CreateInstance(typeof(TViewModel));
    }
}