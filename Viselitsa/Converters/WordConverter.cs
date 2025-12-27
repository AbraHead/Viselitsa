using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Text;

namespace Viselitsa.Converters
{
    internal class WordConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object Parametr, CultureInfo culture)
        {
            //value = (ObservableCollection<Char>)value;
            String rtnValue = "";
             for (int i = 0; i < ((ObservableCollection<char>)value).Count; i++)
            {
                rtnValue += ((ObservableCollection<char>)value)[i];
            }
             return rtnValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ObservableCollection<char> rtnValue = new ObservableCollection<char>() { };
            for (int i = 0; i < ((string)value).Length; i++)
            {
                rtnValue.Add(((string)value)[i]);
            }
            return rtnValue;
        }
    }
}
