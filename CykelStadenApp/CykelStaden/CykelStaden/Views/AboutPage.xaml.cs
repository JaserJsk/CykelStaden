using CykelStaden.ViewModels.About;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace CykelStaden.Views
{
    /// <summary>
    /// About simple page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:CykelStaden.Views.AboutPage"/> class.
        /// </summary>
        public AboutPage()
        {
            this.InitializeComponent();
            this.BindingContext = AboutViewModel.BindingContext;
        }
    }
}