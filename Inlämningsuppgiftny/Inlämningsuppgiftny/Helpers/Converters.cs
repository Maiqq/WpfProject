using System;
using System.Windows.Data;

namespace Inlämningsuppgiftny
{

    public class SelectedItemToItemsSource : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
                    if (value.ToString() == "1.1.0001")
            {
                return null;
            }
            else
            return value.ToString(); 
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value.ToString() != "")
            {
                return value.ToString();
            }
            return value.ToString();
        }
    }
}
