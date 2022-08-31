using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIDelivery.Converters
{
     public class StringToColorConverter : IValueConverter
     {
          public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
          {
               string color = value.ToString();
               return Color.FromArgb(color);

          }

          public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
          {
               throw new NotImplementedException();
          }
     }
}
