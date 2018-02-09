using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinFramework.Core.Services.Interfaces;

namespace XamarinFramework.Core.Services
{
    public class XFStoredPreferences
    {
        private static Dictionary<string, string> StringPreferences = new Dictionary<string, string>();
        private static Dictionary<string, int> IntPreferences = new Dictionary<string, int>();
        private static Dictionary<string, float> FloatPreferences = new Dictionary<string, float>();
        private static Dictionary<string, object> ObjectPreferences = new Dictionary<string, object>();

        public static string GetString(string key)
        {
            return StringPreferences[key];
        }

        public static void SetString(string key, string value)
        {
            StringPreferences[key] = value;
        }

        public static int GetInt(string key)
        {
            return IntPreferences[key];
        }

        public static void SetInt(string key, int value)
        {
            IntPreferences[key] = value;
        }

        public static float GetFloat(string key)
        {
            return FloatPreferences[key];
        }

        public static void SetFloat(string key, float value)
        {
            FloatPreferences[key] = value;
        }

        public static object GetObject(string key)
        {
            return ObjectPreferences[key];
        }

        public static void SetObject(string key, object value)
        {
            ObjectPreferences[key] = value;
        }
    }
}
