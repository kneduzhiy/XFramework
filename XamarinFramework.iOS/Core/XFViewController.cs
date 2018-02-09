using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Foundation;
using UIKit;
using XamarinFramework.Core.Core;

namespace XamarinFramework.iOS.Core
{
    public class XFViewController<TViewModel> : UIViewController where TViewModel : XFViewModel
    {
        private static TViewModel Instance;
        public static TViewModel ViewModel
        {
            get
            {
                if (Instance == null)
                {
                    Instance = (TViewModel)Activator.CreateInstance(typeof(TViewModel));
                }

                return Instance;
            }
        }

        public static XFViewControllerBinder<TViewModel> BindingControl
        {
            get
            {
                var binder = new XFViewControllerBinder<TViewModel>();
                return binder;
            }
        }

        //iOS default constructors
        public XFViewController()
        {
            Initialize();
        }

        public XFViewController(NSCoder coder) : base(coder)
        {
            Initialize();
        }

        public XFViewController(string nibName, NSBundle bundle) : base(nibName, bundle)
        {
            Initialize();
        }

        protected XFViewController(NSObjectFlag t) : base(t)
        {
            Initialize();
        }

        protected internal XFViewController(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        private void Initialize()
        {
            ViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var whichProperty = e.PropertyName;
            XFramework.Log("Changed: " + whichProperty);
            BindingControl.RefreshAllBindings();
        }
    }
}
