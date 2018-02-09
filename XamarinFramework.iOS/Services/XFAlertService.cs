using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using XamarinFramework.Core.Services.Interfaces;

namespace XamarinFramework.iOS.Services
{
    public class XFAlertService : IXFAlertService
    {
        private UIViewController CurrentViewController
        {
            get
            {
                var vc = UIApplication.SharedApplication.KeyWindow.RootViewController;
                while (vc.PresentedViewController != null)
                {
                    vc = vc.PresentedViewController;
                }

                return vc;
            }
        }

        public void ShowConfirmationAlert(string title, string content, Action<bool> confirmedCallback)
        {
            UIAlertController alertController = UIAlertController.Create(title, content, UIAlertControllerStyle.Alert);
            UIAlertAction yesAction = UIAlertAction.Create("Yes", UIAlertActionStyle.Default, delegate
            {
                confirmedCallback.Invoke(true);
                alertController.DismissViewController(true, null);
            });

            UIAlertAction noAction = UIAlertAction.Create("No", UIAlertActionStyle.Cancel, delegate
            {
                confirmedCallback.Invoke(false);
                alertController.DismissViewController(true, null);
            });

            alertController.AddAction(yesAction);
            alertController.AddAction(noAction);

            CurrentViewController.PresentViewController(alertController, true, null);
        }



        public void ShowInfoAlert(string title, string content, bool withButton = true)
        {
            UIAlertController alertController = UIAlertController.Create(title, content, UIAlertControllerStyle.Alert);
            UIAlertAction alertAction = UIAlertAction.Create("Ok", UIAlertActionStyle.Default, delegate
            {
                alertController.DismissViewController(true, null);
            });

            alertController.AddAction(alertAction);

            CurrentViewController.PresentViewController(alertController, true, null);
        }
    }
}