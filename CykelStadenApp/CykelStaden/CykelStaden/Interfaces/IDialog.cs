using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CykelStaden.Interfaces
{
    public interface IDialog
    {
        /* Display a custon alert dialog window */
        Task<bool> DisplayAlert(string icon, string title, string description, string cancel = "Cancel", string confirm = "OK");

        /* Display a regular loading indicator */
        void DisplayLoading();

        /* Display a loading indicator with a message */
        void DisplayLoadingMessage(string customMessage);

        /* Call to hide loading indicator when done with it */
        void HideLoading();

        /* Display a loading indicator with a fake download counter */
        Task DisplayLoadingWithProgressAsync(Func<IProgress<double>, Task> action, string customMessage);

        /* Display a toast message */
        void DisplayToast(string toastMessage, int duration);
    }
}
