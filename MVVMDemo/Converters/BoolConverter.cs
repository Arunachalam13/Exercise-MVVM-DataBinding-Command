using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo.Converters
{
    public class BoolConverter : IValueConverter
    {
        public BoolConverter() { }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var answer = value.ToString();
            if(answer == "Yes")
            {
                return true;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool answer = (bool)value;
            if(answer)
            {
                return "Yes";
            }
            return "No";
        }
    }
}
