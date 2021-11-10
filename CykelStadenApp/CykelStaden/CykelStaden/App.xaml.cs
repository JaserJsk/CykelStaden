using Xamarin.Forms;

[assembly: ExportFont("MaterialIcons-Regular.ttf", Alias = "Material-Regular")]
[assembly: ExportFont("MaterialIconsOutlined-Regular.otf", Alias = "Material-Outlined")]
[assembly: ExportFont("Montserrat-Bold.ttf", Alias = "Montserrat-Bold")]
[assembly: ExportFont("Montserrat-Medium.ttf", Alias = "Montserrat-Medium")]
[assembly: ExportFont("Montserrat-Regular.ttf", Alias = "Montserrat-Regular")]
[assembly: ExportFont("Montserrat-SemiBold.ttf", Alias = "Montserrat-SemiBold")]
[assembly: ExportFont("UIFontIcons.ttf", Alias = "FontIcons")]
namespace CykelStaden
{
    using Xamarin.Forms;

    /// <summary>
    /// Defines the <see cref="App" />.
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Gets the ImageServerPath.
        /// </summary>
        public static string ImageServerPath { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";

        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTI4MjQwQDMxMzkyZTMzMmUzMFFtclhyYU9mTGZITjNIVFZFcFdyN1ZTcEMrN2ZGWkUxSDFRQWFsYitaYVE9");

            InitializeComponent();

            MainPage = new NavigationPage(new MainPage()) {
                BarBackgroundColor = Color.FromHex("#3E94FF"),
                BarTextColor = Color.FromHex("#ffffff")
            };
        }

        /// <summary>
        /// The OnStart.
        /// </summary>
        protected override void OnStart()
        {
        }

        /// <summary>
        /// The OnSleep.
        /// </summary>
        protected override void OnSleep()
        {
        }

        /// <summary>
        /// The OnResume.
        /// </summary>
        protected override void OnResume()
        {
        }
    }
}
