using System;
using AiForms.Dialogs.Abstractions;
using Xamarin.Forms.Xaml;

namespace CykelStaden.Dialogs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlertDialog : DialogView
    {
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