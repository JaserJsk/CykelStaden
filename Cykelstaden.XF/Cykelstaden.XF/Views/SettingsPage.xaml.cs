using Cykelstaden.XF.ViewModels;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Cykelstaden.XF.Views
{
    /// <summary>
    /// Page to show the setting.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsPage"/> class.
        /// </summary>
        public SettingsPage()
        {
            this.InitializeComponent();
            BindingContext = new SettingsViewModel();
        }
    }
}
