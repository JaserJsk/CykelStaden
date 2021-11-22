using CykelStaden.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(CustomNaviPageRenderer))]
namespace CykelStaden.iOS.Renderers
{
    // This is needed to disable the global device darkmode.
    internal class CustomNaviPageRenderer : NavigationRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            OverrideUserInterfaceStyle = UIUserInterfaceStyle.Light;
        }
    }
}