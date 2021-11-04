using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Collections.ObjectModel;
using CykelStaden.Models;
using Xamarin.Forms.Internals;
using System.Runtime.Serialization;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace CykelStaden.ViewModels
{
    /// <summary>
    /// ViewModel of Drawer templates.
    /// </summary>
    [Preserve(AllMembers = true)]
    [DataContract]
    class DrawerViewModel : BaseViewModel
    {

        #region Fields

        private static DrawerViewModel drawerViewModel;

        private string itemIcon;

        private string itemName;

        private Command itemSelectedCommand;

        public static double ScreenWidth = DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density * 0.8;
        public static double ScreenHeight = DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density * 0.25;
        public static double DrawerTopContentHeight = DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density * 0.50;
        public static double DrawerBottomContentHeight = DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density * 0.15;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="T:CykelStaden.ViewModels.About.DrawerViewModel"/> class.
        /// </summary>
        public DrawerViewModel()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the value of drawer page view model.
        /// </summary>
        public static DrawerViewModel BindingContext => 
            drawerViewModel = PopulateData<DrawerViewModel>("drawer.json");

        /// <summary>
        /// Gets or sets the item icon.
        /// </summary>
        /// <value>The item icon.</value>
        [DataMember(Name = "itemIcon")]
        public string ItemIcon
        {
            get
            {
                return App.ImageServerPath + this.itemIcon;
            }

            set
            {
                this.SetProperty(ref this.itemIcon, value);
            }
        }

        /// <summary>
        /// Gets or sets the item name.
        /// </summary>
        /// <value>The item name.</value>
        [DataMember(Name = "itemName")]
        public string ItemName
        {
            get
            {
                return App.ImageServerPath + this.itemName;
            }

            set
            {
                this.SetProperty(ref this.itemName, value);
            }
        }

        /// <summary>
        /// Gets or sets the items list.
        /// </summary>
        /// <value>The item list.</value>
        [DataMember(Name = "itemList")]
        public ObservableCollection<DrawerModel> ItemList { get; set; }

        /// <summary>
        /// Gets the command that will be executed when an item is selected.
        /// </summary>
        public Command ItemSelectedCommand
        {
            get
            {
                return this.itemSelectedCommand ?? (this.itemSelectedCommand = new Command(this.ItemSelected));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Populates the data for view model from json file.
        /// </summary>
        /// <typeparam name="T">Type of view model.</typeparam>
        /// <param name="fileName">Json file to fetch data.</param>
        /// <returns>Returns the view model object.</returns>
        private static T PopulateData<T>(string fileName)
        {
            var file = "CykelStaden.Data." + fileName;

            var assembly = typeof(App).GetTypeInfo().Assembly;

            T data;

            using (var stream = assembly.GetManifestResourceStream(file))
            {
                var serializer = new DataContractJsonSerializer(typeof(T));
                data = (T)serializer.ReadObject(stream);
            }

            return data;
        }

        /// <summary>
        /// Invoked when an item is selected.
        /// </summary>
        private void ItemSelected(object selectedItem)
        {
            // Do something
        }

        #endregion
    }
}
