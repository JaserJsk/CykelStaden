using System;
using AiForms.Dialogs;
using Cykelstaden.XF.Helpers;
using Cykelstaden.XF.Interfaces;
using Cykelstaden.XF.Resources.Langs;
using Cykelstaden.XF.Views.Dialogs;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Internals;
using Cykelstaden.XF.Resources.Icons;

namespace Cykelstaden.XF
{
    /// <summary>
    /// Material Drawer navigation page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        #region Fields
        private IDialog dialogHelper => DialogHelper.Instance;
        #endregion

        #region Constructor
        public MainPage()
        {
            InitializeComponent();
            drawerNavItems();
            LanguageChangedEvent();

            DisplayLoadingMessage();
        }

        #endregion

        #region Methods

        /// <summary>
        /// The drawerNavItems.
        /// </summary>
        private void drawerNavItems()
        {
            List<MenuItem> itemList = new List<MenuItem>();
            itemList.Add(new MenuItem
            {
                ItemIcon = IconFont.LocationOn,
                ItemName = Lang.Map
            });
            itemList.Add(new MenuItem
            {
                ItemIcon = IconFont.Report,
                ItemName = Lang.ErrorReport
            });
            itemList.Add(new MenuItem
            {
                ItemIcon = IconFont.Settings,
                ItemName = Lang.Settings
            });

            listView.ItemsSource = itemList;
        }

        /// <summary>
        /// The menuButton_Clicked.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void menuButton_Clicked(object sender, EventArgs e)
        {
            navigationDrawer.ToggleDrawer();
        }

        /// <summary>
        /// The listView_ItemSelected.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="SelectedItemChangedEventArgs"/>.</param>
        public void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            switch (e.SelectedItemIndex)
            {
                case 0:
                    settingsPage.IsVisible = false;
                    headerLabel.Text = Lang.Map.ToUpper();
                    DisplayToast("This is map screen", 3000);
                    break;

                case 1:
                    settingsPage.IsVisible = false;
                    headerLabel.Text = Lang.ErrorReport.ToUpper();
                    DisplayToast("This is error screen", 3000);
                    break;

                case 2:
                    settingsPage.IsVisible = true;
                    headerLabel.Text = Lang.Settings.ToUpper();
                    break;

                default:
                    settingsPage.IsVisible = false;
                    headerLabel.Text = Lang.AppName.ToUpper();
                    break;
            }

            navigationDrawer.ToggleDrawer();
        }

        /// <summary>
        /// Defines the <see cref="LanguageChangedEvent" />.
        /// </summary>
        private void LanguageChangedEvent()
        {
            MessagingCenter.Subscribe<object, string>(this, "LanguageChanged", (sender, arg) =>
            {
                drawerNavItems();
                headerLabel.Text = Lang.Settings.ToUpper();
            });
        }

        /// <summary>
        /// Defines the <see cref="OnDisappearing" />.
        /// </summary>
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<MainPage>(this, "LanguageChanged");
            MessagingCenter.Unsubscribe<MainPage>(this, "ThemeIsDark");
            MessagingCenter.Unsubscribe<MainPage>(this, "ThemeIsLight");
        }

        /// <summary>
        /// Defines the <see cref="DisplayLoadingMessage" />.
        /// </summary>
        private async Task DisplayLoadingMessage()
        {
            dialogHelper.DisplayLoadingMessage(Lang.PleaseWait);
            await Task.Delay(5000);
            dialogHelper.HideLoading();

            //await dialogHelper.DisplayLoadingWithProgressAsync(progress => ReportProgress(progress), Lang.PleaseWait);
        }

        /// <summary>
        /// Defines the <see cref="ReportProgress" />.
        /// </summary>
        private async Task ReportProgress(IProgress<double> progress)
        {
            for (var i = 0; i < 100; i++)
            {
                await Task.Delay(50);
                progress.Report((i + 1) * 0.01d);
            }
        }

        /// <summary>
        /// Defines the <see cref="DisplayToast" />.
        /// </summary>
        public void DisplayToast(string toastText, int duration)
        {
            Toast.Instance.Show<ToastDialog>(new
            {
                ToastText = toastText,
                Duration = duration
            });
        }

        #endregion
    }

    #region External Class
    /// <summary>
    /// Defines the <see cref="MenuItem" />.
    /// </summary>
    internal class MenuItem
    {
        public string ItemIcon { get; set; }

        public string ItemName { get; set; }
    }
    #endregion
}
