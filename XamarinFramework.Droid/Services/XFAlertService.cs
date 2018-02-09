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
using XamarinFramework.Core.Services.Interfaces;

namespace XamarinFramework.Droid.Services
{
    public class XFAlertService : IXFAlertService
    {
        private AlertDialog ShownDialog;

        public void ShowInfoAlert(string title, string content, bool withButton = true)
        {
            var builder = new AlertDialog.Builder(XFDroidApp.CurrentTopActivity);
            builder.SetTitle(title);
            builder.SetMessage(content);

            if (withButton)
            {
                builder.SetPositiveButton("Ok", delegate
                {
                    ShownDialog.Dismiss();
                });
            }

            ShownDialog = builder.Show();
        }

        public void ShowConfirmationAlert(string title, string content, Action<bool> confirmationCallback)
        {
            var builder = new AlertDialog.Builder(XFDroidApp.CurrentTopActivity);
            builder.SetTitle(title);
            builder.SetMessage(content);

            builder.SetPositiveButton("Ja", delegate {
                confirmationCallback(true);
                ShownDialog.Dismiss();
            });

            builder.SetNegativeButton("Nein", delegate
            {
                confirmationCallback(false);
                ShownDialog.Dismiss();
            });

            ShownDialog = builder.Show();
        }
    }
}