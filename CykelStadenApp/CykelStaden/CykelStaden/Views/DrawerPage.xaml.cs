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

            loadImages();
            changeLogoOnTheme();
        }

        #region Fields

        public static double ScreenWidth = DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density * 0.8;
        public static double ScreenHeight = DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density * 0.25;
        public static double DrawerTopContentHeight = DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density * 0.50;
        public static double DrawerBottomContentHeight = DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density * 0.15;

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

        private void loadImages()
        {
            logoImage.Source = (FileImageSource)ImageSource.FromFile("LogoLight.png");
            headerImage.Source = (FileImageSource)ImageSource.FromFile("header.jpg");
            userImage.Source = (FileImageSource)ImageSource.FromFile("user.jpg");
        }

        void changeLogoOnTheme()
        {
            Application.Current.RequestedThemeChanged += (past, current) =>
            {
                switch (current.RequestedTheme)
                {
                    case OSAppTheme.Dark:
                        logoImage.Source = (FileImageSource)ImageSource.FromFile("LogoDark.png");
                        break;
                    case OSAppTheme.Light:
                        logoImage.Source = (FileImageSource)ImageSource.FromFile("LogoLight.png");
                        break;
                    case OSAppTheme.Unspecified:
                        logoImage.Source = (FileImageSource)ImageSource.FromFile("LogoLight.png");
                        break;
                }
            };
        }

        #endregion
    }
}