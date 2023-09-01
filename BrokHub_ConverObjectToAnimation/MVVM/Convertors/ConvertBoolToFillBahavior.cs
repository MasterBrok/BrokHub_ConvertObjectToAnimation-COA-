using COA_Library.Enums;
using System;
using System.Globalization;
using System.Windows.Data;

namespace BrokHub_ConverObjectToAnimation.MVVM.Convertors
{
    public class ConvertBoolToFillBahavior : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool fill)
                return fill ? FillBehavior.HoldEnd : FillBehavior.Stop;
            return FillBehavior.HoldEnd;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool fill)
                return fill ? FillBehavior.HoldEnd : FillBehavior.Stop;
            return FillBehavior.HoldEnd;
        }
    }
}
