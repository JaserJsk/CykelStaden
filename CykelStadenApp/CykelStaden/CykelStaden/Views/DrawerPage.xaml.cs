using CykelStaden.Resources.Icons;
using CykelStaden.Resources.Langs;
using System;
using System.Collections.Generic;
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
        #region Fields

        #region Statics
        private static string MAP = Lang.ResourceManager.GetString("Map");
        private static string MAPICON = IconFont.ResourceManager.GetString("LocationOn");
        private static string SETTINGS = Lang.ResourceManager.GetString("Settings");
        private static string SETTINGSICON = IconFont.ResourceManager.GetString("Settings");

        public static double DrawerHeaderWidth = DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density * 0.8;
        public static double DrawerHeaderHeight = DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density * 0.25;
        public static double DrawerFooterHeight = DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density * 0.10;
        #endregion

        #region Colors
        private Color BlueColor { get; set; } = Color.FromHex("#277EFF");
        private Color WhiteColor { get; set; } = Color.FromHex("#FFFFFF");
        private Color BlackColor { get; set; } = Color.FromHex("#000000");
        #endregion

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="T:CykelStaden.Views.DrawerPage"/> class.
        /// </summary>
        public DrawerPage()
        {
            this.InitializeComponent();

            checkPlatform();

            loadImages();

            changeLogoOnTheme();

            drawerNavItems();

        }

        #endregion

        #region Methods

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
                else
                {
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
                else
                {
                    footerBg.BackgroundColor = Color.Transparent;
                }
            }
        }

        private void drawerNavItems()
        {
            List<MenuItem> itemList = new List<MenuItem>();
            itemList.Add(new MenuItem { Icon = MAPICON, Name = MAP });
            itemList.Add(new MenuItem { Icon = SETTINGSICON, Name = SETTINGS });
            listView.ItemsSource = itemList;
        }

        private void menuButton_Clicked(object sender, EventArgs e)
        {
            navigationDrawer.ToggleDrawer();
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItemIndex == 0)
            {
                settingsPage.IsVisible = false;

            } else if (e.SelectedItemIndex == 1)
            {
                settingsPage.IsVisible = true;

            }
            
            navigationDrawer.ToggleDrawer();
        } 

        #endregion
    }

    #region External Class

    class MenuItem
    {
        public string Icon { get; set; }
        public string Name { get; set; }
    }

    #endregion
}