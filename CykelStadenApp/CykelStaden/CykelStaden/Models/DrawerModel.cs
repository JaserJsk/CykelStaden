using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;
using Xamarin.Forms.Internals;

namespace CykelStaden.Models
{
    /// <summary>
    /// Model for Drawer Page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [DataContract]
    class DrawerModel : INotifyPropertyChanged
    {
        #region Fields

        private string itemIcon;

        private string itemName;

        private string image;

        #endregion

        #region EventHandler

        /// <summary>
        /// EventHandler of property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the logo of an item.
        /// </summary>
        /// <value>The logo.</value>
        [DataMember(Name = "itemIcon")]
        public string ItemIcon
        {
            get
            {
                return this.itemIcon;
            }

            set
            {
                this.itemIcon = value;
                this.OnPropertyChanged(nameof(this.ItemIcon));
            }
        }

        /// <summary>
        /// Gets or sets the namen of an item.
        /// </summary>
        /// <value>The name.</value>
        [DataMember(Name = "itemName")]
        public string ItemName
        {
            get
            {
                return this.itemName;
            }

            set
            {
                this.itemName = value;
                this.OnPropertyChanged(nameof(this.ItemName));
            }
        }

        /// <summary>
        /// Gets or sets selected image.
        /// </summary>
        /// <value>The image.</value>
        [DataMember(Name = "image")]
        public string Image
        {
            get
            {
                return App.ImageServerPath + this.image;
            }

            set
            {
                this.image = value;
                this.OnPropertyChanged(nameof(this.Image));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// The PropertyChanged event occurs when changing the value of property.
        /// </summary>
        /// <param name="propertyName">The PropertyName</param>
        protected void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
