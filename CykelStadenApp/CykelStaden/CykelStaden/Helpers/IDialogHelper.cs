﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CykelStaden.Helpers
{
    public interface IDialogHelper
    {
        Task<bool> ShowAlert(string dialogText, string acceptText = "OK", string cancelText = "Cancel");

        //void ShowLoading();

        //void ShowLoading(string customMessage);

        //void HideLoading();

        //Task ShowLoadingWithProgressAsync(Func<IProgress<double>, Task> action, string customMessage);

        //void DisplayToast(string toastMessage, int duration = 3000);
    }
}
