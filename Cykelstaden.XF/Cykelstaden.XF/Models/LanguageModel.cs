using System;
using System.Collections.Generic;
using System.Text;

namespace Cykelstaden.XF.Models
{
    public class LanguageModel
    {
        public string LangName { get; set; }
        public string LangCI { get; set; }

        public LanguageModel(string langName, string langCI)
        {
            LangName = langName;
            LangCI = langCI;
        }
    }
}
