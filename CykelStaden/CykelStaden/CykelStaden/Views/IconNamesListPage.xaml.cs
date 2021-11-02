using CykelStaden.DataService;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace CykelStaden.Views
{
    /// <summary>
    /// Page showing the list of names
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IconNamesListPage
    {
        public IconNamesListPage()
        {
            this.InitializeComponent();
            this.BindingContext = IconNamesListDataService.Instance.IconNamesListPageViewModel;
        }
    }
}