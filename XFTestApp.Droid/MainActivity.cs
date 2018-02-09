using Android.App;
using Android.Widget;
using Android.OS;
using XamarinFramework.Droid.Core;
using XamarinFramework.Core.Services;
using System;
using XamarinFramework.Core.Core;
using XamarinFramework.Core.Services.Interfaces;

namespace XFTestApp.Droid
{
    [Activity(Label = "Xamarin", MainLauncher = true)]
    public class MainActivity : XFActivity
    {
        private Button _testButton;
        private IXFPersistedStoredPreferences _preferences;
        private IXFAlertService _alertService;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            
            _preferences = XFramework.GetService<IXFPersistedStoredPreferences>();
            _alertService = XFramework.GetService<IXFAlertService>();

            _testButton = FindViewById<Button>(Resource.Id.testButton);
            _testButton.Click += OnTestButtonClicked;
        }

        private void OnTestButtonClicked(object sender, EventArgs e)
        {
            
        }
    }
}

