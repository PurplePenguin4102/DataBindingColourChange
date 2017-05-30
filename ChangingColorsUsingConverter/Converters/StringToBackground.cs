using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace ChangingColorsUsingConverter.Converters
{
    public class StringToBackground : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var name = (string)value;
            if (name == "Billy")
                return "Blue";
            else
                return "Red";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
