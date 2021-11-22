using Foundation;
using UIKit;
using Syncfusion.XForms.iOS.Core;
using Syncfusion.ListView.XForms.iOS;
using Syncfusion.XForms.iOS.Buttons;

namespace CykelStaden.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            new Syncfusion.SfNavigationDrawer.XForms.iOS.SfNavigationDrawerRenderer();

            global::Xamarin.Forms.Forms.Init();
            //SfRatingRenderer.Init();
            SfListViewRenderer.Init();
            //SfComboBoxRenderer.Init();
            //SfTextInputLayoutRenderer.Init();
            SfAvatarViewRenderer.Init();
            //SfBorderRenderer.Init();
            //SfSegmentedControlRenderer.Init();
            //SfRadioButtonRenderer.Init();
            //SfGradientViewRenderer.Init();
            SfButtonRenderer.Init();
            AiForms.Dialogs.Dialogs.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }

        public override void OnActivated(UIApplication uiApplication)
        {
            if (UIDevice.CurrentDevice.CheckSystemVersion(13, 0))
            {
                // If VS has updated to the latest version , you can use StatusBarManager , else use the first line code
                // UIView statusBar = new UIView(UIApplication.SharedApplication.StatusBarFrame);
                UIView statusBar = new UIView(UIApplication.SharedApplication.KeyWindow.WindowScene.StatusBarManager.StatusBarFrame);
                statusBar.BackgroundColor = UIColor.FromRGB(62, 148, 255); // Same as #3E94FF
                UIApplication.SharedApplication.KeyWindow.AddSubview(statusBar);
            }
            else
            {
                UIView statusBar = UIApplication.SharedApplication.ValueForKey(new NSString("statusBar")) as UIView;
                if (statusBar.RespondsToSelector(new ObjCRuntime.Selector("setBackgroundColor:")))
                {
                    statusBar.BackgroundColor = UIColor.FromRGB(62, 148, 255); // Same as #3E94FF
                    UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.BlackOpaque;
                }
            }
            base.OnActivated(uiApplication);
        }
    }
}
