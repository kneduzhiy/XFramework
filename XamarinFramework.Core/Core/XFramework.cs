using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinFramework.Core.Core
{
    public class XFramework
    {
        private static Dictionary<Type, dynamic> _serviceRegister = new Dictionary<Type, dynamic>();

        public static void RegisterService<TService>(TService serviceInstance)
        {
            var serviceType = typeof(TService);
            if (!(_serviceRegister.ContainsKey(serviceType)))
            {
                _serviceRegister.Add(serviceType, serviceInstance);
                Log("Registering service instance for " + serviceType.Name, "XF_Internal");
            }
            else
            {
                Log(serviceType.Name + " is already registered, ignoring attempt to re-register", "XF_Internal");
            }
        }

        public static TService GetService<TService>()
        {
            var serviceType = typeof(TService);
            return _serviceRegister[serviceType];
        }

        public static void Log(string message, string tag = "")
        {
            bool taggedLog = tag != "";
            if(taggedLog)
            {
                Debug.WriteLine("[" + tag + "] " + message);
            }
            else
            {
                Debug.WriteLine(message);
            }
        }
    }
}
