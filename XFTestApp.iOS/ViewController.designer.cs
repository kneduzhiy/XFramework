// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XFTestApp.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CheckLoginButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField PinTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel PreferencesText { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CheckLoginButton != null) {
                CheckLoginButton.Dispose ();
                CheckLoginButton = null;
            }

            if (PinTextField != null) {
                PinTextField.Dispose ();
                PinTextField = null;
            }

            if (PreferencesText != null) {
                PreferencesText.Dispose ();
                PreferencesText = null;
            }
        }
    }
}