using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinFramework.Core.Services.Interfaces
{
    /// <summary>
    /// General interface for key-value preference storage.
    /// </summary>
    public interface IXFPersistedStoredPreferences
    {
        string GetString(string key);
        void SetString(string key, string value);
        int GetInt(string key);
        void SetInt(string key, int value);
        float GetFloat(string key);
        void SetFloat(string key, float value);
        bool GetBool(string key);
        void SetBool(string key, bool value);
        IList<string> GetStringList(string key);
        void SetStringList(string key, IList<string> value);
    }
}
