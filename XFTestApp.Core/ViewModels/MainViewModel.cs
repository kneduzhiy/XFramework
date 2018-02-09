using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinFramework.Core.Core;
using XamarinFramework.Core.Core.ViewModels;
using XamarinFramework.Core.Services.Interfaces;

namespace XFTestApp.Core.ViewModels
{
    public class MainViewModel : XFViewModel
    {
        private readonly IXFPersistedStoredPreferences _preferences;
        private readonly IXFAlertService _alertService;

        public MainViewModel()
        {
            _preferences = XFramework.GetService<IXFPersistedStoredPreferences>();
            _alertService = XFramework.GetService<IXFAlertService>();

            XFramework.Log("Initialized!", "MainViewModel");
        }

        public string ValidPin
        {
            get
            {
                return "7474";
            }

            set
            {
                ValidPin = value;
                XFNotifyPropertyChanged("ValidPin");
            }
        }

        public string PreferenceText
        {
            get
            {
                return _preferences.GetString("lastEnteredPassword");
            }

            set
            {
                _preferences.SetString("lastEnteredPassword", value);
                XFNotifyPropertyChanged("PreferenceText");
            }
        }

        public XFCommand CheckPinCommand
        {
            get
            {
                return new XFCommand(() =>
                {
                    var pinToCheck = "23";
                    PreferenceText = pinToCheck;

                    if (pinToCheck == ValidPin)
                    {
                        _alertService.ShowInfoAlert("VM Congrats!", "The password was correct.");
                    }
                    else
                    {
                        _alertService.ShowInfoAlert("VM Oh noo!", "Sadly the password was incorrect.");
                    }
                });
            }
        }

        public void CheckPin(string givenPin)
        {
            var pinToCheck = givenPin;
            PreferenceText = pinToCheck;

            if (pinToCheck == ValidPin)
            {
                _alertService.ShowInfoAlert("VM Congrats!", "The password was correct.");
            }
            else
            {
                _alertService.ShowInfoAlert("VM Oh noo!", "Sadly the password was incorrect.");
            }
        }
    }
}
