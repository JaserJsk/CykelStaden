using CykelStaden.ViewModels;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace CykelStaden.Views
{
    /// <summary>
    /// Material Drawer navigation page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrawerPage : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:CykelStaden.Views.DrawerPage"/> class.
        /// </summary>
        public DrawerPage()
        {
            this.InitializeComponent();
            this.BindingContext = DrawerViewModel.BindingContext;

            checkPlatform();
            loadImages();
            changeLogoOnTheme();
        }

        #region Fields

        private Color BlueColor { get; set; } = Color.FromHex("#277EFF");
        private Color WhiteColor { get; set; } = Color.FromHex("#FFFFFF");
        private Color BlackColor { get; set; } = Color.FromHex("#000000");

        public static double DrawerHeaderWidth = DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density * 0.8;
        public static double DrawerHeaderHeight = DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density * 0.25;
        public static double DrawerFooterHeight = DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density * 0.10;

        #endregion

        #region Methods

        private void menuButton_Clicked(object sender, EventArgs e)
        {
            navigationDrawer.ToggleDrawer();
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            navigationDrawer.ToggleDrawer();
        }

        private void checkPlatform()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    drawerNavBar.BackgroundColor = BlueColor;
                    menuButton.TextColor = WhiteColor;
                    break;

                case Device.iOS:
                    drawerNavBar.BackgroundColor = WhiteColor;
                    menuButton.TextColor = BlackColor;
                    break;
            } 
        }

        private void loadImages()
        {
            logoImage.Source = (FileImageSource)ImageSource.FromFile("LogoLight.png");
            headerImage.Source = (FileImageSource)ImageSource.FromFile("header.jpg");
            userImage.Source = (FileImageSource)ImageSource.FromFile("user.jpg");
        }

        void changeLogoOnTheme()
        {
            if (AppInfo.RequestedTheme == AppTheme.Dark)
            {
                logoImage.Source = (FileImageSource)ImageSource.FromFile("LogoDark.png");
                if (Device.RuntimePlatform == Device.iOS)
                {
                    footerBg.BackgroundColor = BlackColor;
                }
                else {
                    footerBg.BackgroundColor = Color.Transparent;
                }

            }
            else
            {
                logoImage.Source = (FileImageSource)ImageSource.FromFile("LogoLight.png");
                if (Device.RuntimePlatform == Device.iOS)
                {
                    footerBg.BackgroundColor = WhiteColor;
                }
                else {
                    footerBg.BackgroundColor = Color.Transparent;
                }
            }
        }

        #endregion
    }
}