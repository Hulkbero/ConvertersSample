using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ConvertersSample
{
    public class StringToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return Color.Transparent;

            if (!Enum.TryParse(value.ToString(), out Weather weatherValue))
                return Color.Transparent;

            switch (weatherValue)
            {
                case Weather.cloudy:
                    return Color.LightGray;

                case Weather.sunny:
                    return Color.Yellow;

                case Weather.cold:
                    return Color.Blue;

                case Weather.hot:
                    return Color.Red;

                default:
                    return Color.Transparent;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
