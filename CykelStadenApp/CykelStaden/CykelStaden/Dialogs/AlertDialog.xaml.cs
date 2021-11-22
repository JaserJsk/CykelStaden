using AiForms.Dialogs.Abstractions;
using System;
using Xamarin.Essentials;
using Xamarin.Forms.Xaml;

namespace CykelStaden.Dialogs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlertDialog : DialogView
    {
        public static double DialogWidth = DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density * 0.7;

        public AlertDialog()
        {
            InitializeComponent();
        }

        public override void SetUp()
        {
            base.SetUp();
        }

        public override void TearDown()
        {
            base.TearDown();
        }

        public override void Destroy()
        {
            base.Destroy();
        }

        private void CancelAndClose_Tapped(object sender, EventArgs e)
        {
            DialogNotifier.Cancel();
        }

        private void AcceptAndClose_Tapped(object sender, EventArgs e)
        {
            DialogNotifier.Complete();
        }
    }
}