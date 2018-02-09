using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinFramework.Core.Services.Interfaces
{
    public interface IXFAlertService
    {
        void ShowInfoAlert(string title, string content, bool withButton = true);
        void ShowConfirmationAlert(string title, string content, Action<bool> confirmationCallback);
    }
}
