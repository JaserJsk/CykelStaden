using System;
using AiForms.Dialogs;
using System.Threading.Tasks;
using CykelStaden.Interfaces;
using CykelStaden.Dialogs;

namespace CykelStaden.Helpers
{
    public class DialogHelper : IDialog
    {
        private static readonly Lazy<IDialog> instance = new Lazy<IDialog>(() => CreateDialog());

        private static IDialog CreateDialog() => new DialogHelper();

        public static IDialog Instance => instance.Value;

        public async Task<bool> DisplayAlert(string icon, string title, string description, string cancel = "Cancel", string confirm = "OK")
        {
            return await Dialog.Instance.ShowAsync<AlertDialog>(new
            {
                Icon = icon,
                Title = title,
                Description = description,
                Cancel = cancel,
                Confirm = confirm
            });
        }

        public void DisplayLoading()
        {
            Loading.Instance.Show("Please wait...");
        }

        public void DisplayLoadingMessage(string customMessage)
        {
            Loading.Instance.Show();
            if (!string.IsNullOrEmpty(customMessage))
            {
                Loading.Instance.SetMessage(customMessage);
            }
        }

        public void HideLoading()
        {
            Loading.Instance.Hide();
        }

        public async Task DisplayLoadingWithProgressAsync(Func<IProgress<double>, Task> action, string customMessage)
        {
            await Loading.Instance.StartAsync(action, customMessage);
        }

        public void DisplayToast(string toastText, int duration)
        {
            Toast.Instance.Show<ToastDialog>(new
            {
                ToastText = toastText,
                Duration = duration
            });
        }
    }
}
