using Cykelstaden.XF.ViewModels.About;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Cykelstaden.XF.Views
{
    /// <summary>
    /// About simple page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AboutPage"/> class.
        /// </summary>
        public AboutPage()
        {
            this.InitializeComponent();
            BindingContext = new AboutViewModel();
        }
    }
}
