using Plugin.Messaging;
using System.Runtime.Serialization;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace CykelStaden.ViewModels.About
{
    /// <summary>
    /// ViewModel of About templates.
    /// </summary>
    [Preserve(AllMembers = true)]
    [DataContract]
    public class AboutViewModel : BaseViewModel
    {
        #region Fields

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="AboutViewModel"/> class.
        /// </summary>
        public AboutViewModel()
        {
            this.EmailCommand = new Command(this.EmailClicked);
            this.PhoneCommand = new Command(this.PhoneClicked);
        }

        #endregion

        #region Properties

        public Command EmailCommand { get; set; }

        public Command PhoneCommand { get; set; }

        #endregion

        #region Methods

        private void EmailClicked(object obj)
        {
            var emailAddress = "goteborg@goteborg.se";
            var emailer = CrossMessaging.Current.EmailMessenger;
            if (emailer.CanSendEmail)
            {
                emailer.SendEmail(emailAddress);
            }
        }

        private void PhoneClicked(object obj)
        {
            var phoneNumber = "031-3650000";
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall)
            {
                phoneDialer.MakePhoneCall(phoneNumber);
            }
        }

        #endregion
    }
}
