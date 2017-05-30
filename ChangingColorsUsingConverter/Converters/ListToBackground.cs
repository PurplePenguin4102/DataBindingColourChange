using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace ChangingColorsUsingConverter.Converters
{
    public class ListToBackground : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var collection = (ObservableCollection<int>)value;
            if (collection.Where(x => x > 8).Any())
                return "Bisque";
            else
                return "DarkSeaGreen";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
