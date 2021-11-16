using CykelStaden.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Picker), typeof(CustomPickerRenderer))]
namespace CykelStaden.iOS.Renderers
{
    public class CustomPickerRenderer : PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if (Control == null || e.NewElement == null)
                return;
            Control.Layer.BorderWidth = 1;
            Control.Layer.BorderColor = Color.Transparent.ToCGColor();
        }
    }
}