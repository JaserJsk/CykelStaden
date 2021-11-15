using Acr.UserDialogs;
using CykelStaden.Helpers;
using CykelStaden.Models;
using CykelStaden.Resources.Langs;
using CykelStaden.Views;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace CykelStaden.ViewModels
{
    /// <summary>
    /// ViewModel for Setting page.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class SettingsViewModel : BaseViewModel
    {
        #region Fields

        /// <summary>
        /// Defines the PickerWidth.
        /// </summary>
        public static double PickerWidth = DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density * 0.8;

        /// <summary>
        /// Defines the toggleTheme.
        /// </summary>
        private bool toggleTheme;

        /// <summary>
        /// Defines the isLightTheme.
        /// </summary>
        private bool isDarkTheme = false;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsViewModel"/> class.
        /// </summary>
        public SettingsViewModel()
        {
            LoadLanguages();
            ChangeLangugeCommand = new Command(async () =>
            {
                LocalizationResourceManager.Instance.SetCulture(CultureInfo.GetCultureInfo(SelectedLanguage.LangCI));
                LoadLanguages();

                await UserDialogs.Instance.AlertAsync(Lang.LangChangedDesc, Lang.LangChanged, Lang.Done);
            });

            this.AboutCommand = new Command(this.AboutClicked);
            this.SteerSetCommand = new Command(this.SteerSetClicked);
            this.PrivacyPolicyCommand = new Command(this.PrivacyPolicyClicked);
            this.FAQCommand = new Command(this.FAQClicked);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the languagesModel.
        /// </summary>
        public ObservableCollection<LanguageModel> languagesModel { get; set; }

        /// <summary>
        /// Gets or sets the SelectedLanguage.
        /// </summary>
        public LanguageModel SelectedLanguage { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether ToggleTheme
        /// Gets or sets the theme of the app..
        /// </summary>
        public bool ToggleTheme
        {
            get
            {
                return toggleTheme;
            }
            set
            {
                toggleTheme = value;
                OnToggleTheme();
            }
        }

        /// <summary>
        /// Gets or sets the command is executed when the change languge option is clicked..
        /// </summary>
        public ICommand ChangeLangugeCommand { get; set; }

        /// <summary>
        /// Gets or sets the command is executed when the about option is clicked..
        /// </summary>
        public Command AboutCommand { get; set; }

        /// <summary>
        /// Gets or sets the command is executed when the steer & set option is clicked..
        /// </summary>
        public Command SteerSetCommand { get; set; }

        /// <summary>
        /// Gets or sets the command is executed when the privacy & policy option is clicked..
        /// </summary>
        public Command PrivacyPolicyCommand { get; set; }

        /// <summary>
        /// Gets or sets the command is executed when the FAQ option is clicked..
        /// </summary>
        public Command FAQCommand { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when the theme option is switched.
        /// </summary>
        private void OnToggleTheme()
        {

            if (!isDarkTheme)
            {
                ICollection<ResourceDictionary> mergedDictionaries = App.Current.Resources.MergedDictionaries;
                var lightTheme = mergedDictionaries.OfType<Themes.LightTheme>().FirstOrDefault();
                if (lightTheme != null)
                {
                    mergedDictionaries.Remove(lightTheme);
                }

                mergedDictionaries.Add(new Themes.DarkTheme());
                isDarkTheme = true;
            }
            else
            {
                ICollection<ResourceDictionary> mergedDictionaries = App.Current.Resources.MergedDictionaries;
                var darkTheme = mergedDictionaries.OfType<Themes.DarkTheme>().FirstOrDefault();
                if (darkTheme != null)
                {
                    mergedDictionaries.Remove(darkTheme);
                }

                mergedDictionaries.Add(new Themes.LightTheme());
                isDarkTheme = false;
            }
        }

        /// <summary>
        /// Loading all available languages at runtime.
        /// </summary>
        private void LoadLanguages()
        {
            languagesModel = new ObservableCollection<LanguageModel>()
            {
                {new LanguageModel(Lang.Swedish, "se") },
                {new LanguageModel(Lang.English, "en") },
            };
            SelectedLanguage = languagesModel.FirstOrDefault(pro => pro.LangCI == LocalizationResourceManager.Instance.CurrentCulture.TwoLetterISOLanguageName);
        }

        /// <summary>
        /// Invoked when the about option clicked.
        /// </summary>
        /// <param name="obj">The object.</param>
        private async void AboutClicked(object obj)
        {
            await App.Current.MainPage.Navigation.PushAsync(new AboutPage());
        }

        /// <summary>
        /// Invoked when the steer & set clicked.
        /// </summary>
        /// <param name="obj">The object.</param>
        private void SteerSetClicked(object obj)
        {
        }

        /// <summary>
        /// Invoked when the privacy and policy clicked.
        /// </summary>
        /// <param name="obj">The object.</param>
        private void PrivacyPolicyClicked(object obj)
        {
        }

        /// <summary>
        /// Invoked when the FAQ clicked.
        /// </summary>
        /// <param name="obj">The object.</param>
        private void FAQClicked(object obj)
        {
        }

        #endregion

    }
}
