using System;
using System.Collections.Generic;
using System.Text;

namespace CykelStaden.Globals
{
    public class GlobalAccess
    {
        public static bool themeIsLight = true;
        public static bool ThemeIsLight
        {
            get { return themeIsLight; }
            set { themeIsLight = value; }
        }


    }
}
