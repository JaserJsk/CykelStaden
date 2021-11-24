using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Syncfusion.ListView.XForms.iOS;
using Syncfusion.SfRating.XForms.iOS;
using Syncfusion.XForms.iOS.Buttons;
using Syncfusion.XForms.iOS.ComboBox;
using Syncfusion.XForms.iOS.Core;
using UIKit;

namespace Cykelstaden.XF.iOS
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
            global::Xamarin.Forms.Forms.Init();
            SfRatingRenderer.Init();
            SfListViewRenderer.Init();
            SfComboBoxRenderer.Init();
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
                statusBar.BackgroundColor = UIColor.FromRGB(0, 118, 188); // Same as #0076bc
                UIApplication.SharedApplication.KeyWindow.AddSubview(statusBar);
            }
            else
            {
                UIView statusBar = UIApplication.SharedApplication.ValueForKey(new NSString("statusBar")) as UIView;
                if (statusBar.RespondsToSelector(new ObjCRuntime.Selector("setBackgroundColor:")))
                {
                    statusBar.BackgroundColor = UIColor.FromRGB(0, 118, 188); // Same as #0076bc
                    UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.BlackOpaque;
                }
            }
            base.OnActivated(uiApplication);
        }
    }
}
