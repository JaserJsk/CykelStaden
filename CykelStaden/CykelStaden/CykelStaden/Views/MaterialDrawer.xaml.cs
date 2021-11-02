using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Syncfusion.SfNavigationDrawer.XForms;
using Xamarin.Essentials;

namespace CykelStaden.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MaterialDrawer : ContentPage
    {
        public MaterialDrawer()
        {
            InitializeComponent();
            headerImage.Source = (FileImageSource)ImageSource.FromFile("header.jpg");
            userImage.Source = (FileImageSource)ImageSource.FromFile("user.jpg");

            List<string> list = new List<string>();
            list.Add("Home");
            list.Add("Profile");
            list.Add("Inbox");
            list.Add("Out box");
            list.Add("Sent");
            list.Add("Draft");
            listView.ItemsSource = list;

        }

        void hamburgerButton_Clicked(object sender, EventArgs e)
        {
            navigationDrawer.ToggleDrawer();
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // Your codes here
            navigationDrawer.ToggleDrawer();
        }
    }

    public struct Constant
    {
        public static double ScreenWidth = DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density * 0.8;
        public static double ScreenHeight = DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density * 0.25;
    }
}