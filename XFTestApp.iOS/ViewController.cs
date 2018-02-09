using System;

using UIKit;
using XamarinFramework.Core.Core;
using XamarinFramework.Core.Services.Interfaces;
using XamarinFramework.iOS.Core;
using XFTestApp.Core.ViewModels;

namespace XFTestApp.iOS
{
    public partial class ViewController : XFViewController<MainViewModel>
    {
      //  private IXFAlertService alertService;

        public ViewController(IntPtr handle) : base(handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            
            PreferencesText.BindToText(() => ViewModel.PreferenceText);
            CheckLoginButton.BindToCommand(() => ViewModel.CheckPinCommand);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}