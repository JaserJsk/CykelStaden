using System;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: NeutralResourcesLanguage("sv-SE")]
[assembly: ExportFont("MaterialIcons-Regular.ttf", Alias = "Material-Regular")]
[assembly: ExportFont("MaterialIconsOutlined-Regular.otf", Alias = "Material-Outlined")]
[assembly: ExportFont("Montserrat-Bold.ttf",Alias="Montserrat-Bold")]
[assembly: ExportFont("Montserrat-Medium.ttf", Alias = "Montserrat-Medium")]
[assembly: ExportFont("Montserrat-Regular.ttf", Alias = "Montserrat-Regular")]
[assembly: ExportFont("Montserrat-SemiBold.ttf", Alias = "Montserrat-SemiBold")]
[assembly: ExportFont("UIFontIcons.ttf", Alias = "FontIcons")]
namespace CykelStaden
{
    public partial class App : Application
    {
        public static string ImageServerPath { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";
        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTI4MjQwQDMxMzkyZTMzMmUzMFFtclhyYU9mTGZITjNIVFZFcFdyN1ZTcEMrN2ZGWkUxSDFRQWFsYitaYVE9");

            InitializeComponent();

            MainPage = new Views.DrawerPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
