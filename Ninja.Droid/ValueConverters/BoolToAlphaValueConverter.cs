using System;
using System.Globalization;
using Android.Graphics;
using MvvmCross.Platform.Converters;

namespace Ninja.Droid.ValueConverters
{
    public class BoolToAlphaValueConverter : IMvxValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
            {
                return 1;
            }

            return .35;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((double)value == 1)
            {
                return true;
            }

            return false;
        }
    }
}