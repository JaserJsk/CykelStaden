using Cykelstaden.XF.Resources.Langs;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;
using Xamarin.Essentials;

namespace Cykelstaden.XF.Helpers
{
    public class LocalizationResourceManager : INotifyPropertyChanged
    {
        private const string LanguageKey = nameof(LanguageKey);

        public static LocalizationResourceManager Instance { get; } = new LocalizationResourceManager();

        private LocalizationResourceManager()
        {
            SetCulture(new CultureInfo(Preferences.Get(LanguageKey, CurrentCulture.TwoLetterISOLanguageName)));
        }

        public string this[string text]
        {
            get
            {
                return Lang.ResourceManager.GetString(text, Lang.Culture);
            }
        }

        public void SetCulture(CultureInfo language)
        {
            Thread.CurrentThread.CurrentUICulture = language;
            Lang.Culture = language;
            Preferences.Set(LanguageKey, language.TwoLetterISOLanguageName);

            Invalidate();
        }

        public string GetValue(string text, string ResourceId)
        {
            ResourceManager resourceManager = new ResourceManager(ResourceId, typeof(TranslateExtension).GetTypeInfo().Assembly);
            return resourceManager.GetString(text, CultureInfo.CurrentCulture);
        }

        public CultureInfo CurrentCulture => Lang.Culture ?? Thread.CurrentThread.CurrentUICulture;

        public event PropertyChangedEventHandler PropertyChanged;

        public void Invalidate()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }
    }
}
