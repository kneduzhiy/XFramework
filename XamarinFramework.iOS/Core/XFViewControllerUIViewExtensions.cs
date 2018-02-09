using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using System.Linq.Expressions;
using XamarinFramework.Core.Core.ViewModels;

namespace XamarinFramework.iOS.Core
{
    public static class XFViewControllerUIViewExtensions
    {
        public static void BindToCommand<T>(this UIButton button, Func<T> xfCommand) where T : XFCommand
        {
            button.TouchUpInside += delegate
            {
                xfCommand().Execute();
            };
        }

        public static void BindToText(this UILabel label, Func<string> text)
        {
            label.Text = text();
        }

        private static void BindingSubscribe()
        {

        }
    }
}