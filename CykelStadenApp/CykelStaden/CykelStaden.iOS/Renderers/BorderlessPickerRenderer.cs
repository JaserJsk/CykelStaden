using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using CykelStaden.iOS.Renderers;
using CykelStaden.Controls;

[assembly: ExportRenderer(typeof(BorderlessPicker), typeof(BorderlessPickerRenderer))]
namespace CykelStaden.iOS.Renderers
{
    public class BorderlessPickerRenderer : PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            Control.Layer.BorderWidth = 0;
            Control.BorderStyle = UITextBorderStyle.None;

            MessagingCenter.Subscribe<object, string>(this, "ThemeIsDark", (sender, arg) =>
            {
                this.OverrideUserInterfaceStyle = UIUserInterfaceStyle.Dark;
            });

            MessagingCenter.Subscribe<object, string>(this, "ThemeIsLight", (sender, arg) =>
            {
                this.OverrideUserInterfaceStyle = UIUserInterfaceStyle.Light;
            });
        }
    }
}