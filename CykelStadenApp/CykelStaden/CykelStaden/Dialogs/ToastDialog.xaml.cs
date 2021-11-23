using AiForms.Dialogs.Abstractions;
using Xamarin.Forms.Xaml;

namespace CykelStaden.Dialogs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToastDialog : ToastView
    {
        public ToastDialog()
        {
            InitializeComponent();
        }
    }
}