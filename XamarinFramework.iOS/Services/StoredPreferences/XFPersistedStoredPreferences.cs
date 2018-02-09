using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using XamarinFramework.Core.Services.Interfaces;

namespace XamarinFramework.iOS.Services.StoredPreferences
{
    public class XFPersistedStoredPreferences : IXFPersistedStoredPreferences
    {
        private NSUserDefaults Preferences => NSUserDefaults.StandardUserDefaults;

        public bool GetBool(string key)
        {
            return Preferences.BoolForKey(key);
        }

        public float GetFloat(string key)
        {
            return Preferences.FloatForKey(key);
        }

        public int GetInt(string key)
        {
            return (int)Preferences.IntForKey(key);
        }

        public string GetString(string key)
        {
            return Preferences.StringForKey(key);
        }

        public IList<string> GetStringList(string key)
        {
            return Preferences.StringArrayForKey(key);
        }

        public void SetBool(string key, bool value)
        {
            Preferences.SetBool(value, key);
        }

        public void SetFloat(string key, float value)
        {
            Preferences.SetFloat(value, key);
        }

        public void SetInt(string key, int value)
        {
            Preferences.SetInt(value, key);
        }

        public void SetString(string key, string value)
        {
            Preferences.SetString(value, key);
        }

        public void SetStringList(string key, IList<string> value)
        {
            Preferences.SetValueForKey(NSObject.FromObject(value), (NSString)key);
        }
    }
}