
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Data;

namespace BrokHub_ConverObjectToAnimation.MVVM.Convertors
{
    public class ConvertBoolToNameFrame : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                if (parameter is string cc)
                {
                    if (cc.Equals("String"))
                    {
                        return nameof(String);
                    }
                    else if (cc.Equals("Double"))
                    {
                        return nameof(Double);
                    }
                    else if (cc.Equals("Color"))
                    {
                        return nameof(Color);
                    }
                }
            }
            catch (Exception)
            {

                throw new Exception("Convert Is Faile");
            }
            return typeof(byte);
            //throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                if (parameter is string cc)
                {
                    if (cc.Equals("String"))
                    {
                        return nameof(String);
                    }
                    else if (cc.Equals("Double"))
                    {
                        return nameof(Double);
                    }
                    else if (cc.Equals("Color"))
                    {
                        return nameof(Color);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Convert Is Faile");
            }
            return null;
        }
    }
}
