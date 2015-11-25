using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace SigaaWindows.Converters
{
    public class DeliveryDateToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            DateTime deliveryDate = System.Convert.ToDateTime(value);
            if (deliveryDate < DateTime.Today.AddDays(-5))
                return new SolidColorBrush(Windows.UI.Color.FromArgb(100, 207, 0, 15));
            else
                return new SolidColorBrush(Windows.UI.Color.FromArgb(100, 247, 202, 24));
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
