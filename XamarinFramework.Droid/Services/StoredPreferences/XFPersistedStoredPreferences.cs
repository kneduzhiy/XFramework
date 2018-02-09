using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Preferences;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinFramework.Core.Core;
using XamarinFramework.Core.Services.Interfaces;

namespace XamarinFramework.Droid.Services.StoredPreferences
{
    public class XFPersistedStoredPreferences : IXFPersistedStoredPreferences
    {
        private ISharedPreferences Preferences => PreferenceManager.GetDefaultSharedPreferences(Application.Context);
        private ISharedPreferencesEditor PreferencesEditor => Preferences.Edit();

        public bool GetBool(string key)
        {
            return Preferences.GetBoolean(key, false);
        }

        public float GetFloat(string key)
        {
            return Preferences.GetFloat(key, 0f);
        }

        public int GetInt(string key)
        {
            return Preferences.GetInt(key, 0);
        }

        public string GetString(string key)
        {
            return Preferences.GetString(key, string.Empty);
        }

        public IList<string> GetStringList(string key)
        {
            var emptyStringList = new List<string> { };
           return Preferences.GetStringSet(key, emptyStringList).ToList();
        }

        public void SetBool(string key, bool value)
        {
            PreferencesEditor.PutBoolean(key, value);
            PreferencesEditor.Apply();
        }

        public void SetFloat(string key, float value)
        {
            PreferencesEditor.PutFloat(key, value);
            PreferencesEditor.Apply();
        }

        public void SetInt(string key, int value)
        {
            PreferencesEditor.PutInt(key, value);
            PreferencesEditor.Apply();
        }

        public void SetString(string key, string value)
        {
            PreferencesEditor.PutString(key, value);
            PreferencesEditor.Apply();
        }

        public void SetStringList(string key, IList<string> value)
        {
            PreferencesEditor.PutStringSet(key, value);
            PreferencesEditor.Apply();
        }
    }
}