using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ConvertersSample
{
    public class MeterToKiloConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return "--";

            if (!double.TryParse(value.ToString(), out double doubleValue))
            {
                return "--";
            }
            else
            {
                doubleValue = doubleValue / 1000;
                return Math.Round(doubleValue, 1).ToString() + " Km";
            }

           

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
