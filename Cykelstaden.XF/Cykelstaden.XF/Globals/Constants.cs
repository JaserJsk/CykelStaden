using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace Cykelstaden.XF.Globals
{
    public class Constants
    {
        public static double Width_08 = DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density * 0.8;

        public static double Width_07 = DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density * 0.7;

        public static double Height_10 = DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density * 0.10;

        public static double Height_25 = DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density * 0.25;

    }
}
