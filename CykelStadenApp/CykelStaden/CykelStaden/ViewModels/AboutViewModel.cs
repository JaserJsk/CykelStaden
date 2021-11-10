using System.Runtime.Serialization;
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

        private static AboutViewModel aboutUsViewModel;

        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="AboutViewModel"/> class.
        /// </summary>
        public AboutViewModel()
        {
        }

        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion
    }
}
