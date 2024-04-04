using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Vitalize_Vault.Converter
{
    public class ExpirationDateToBackgroundColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null) return Brushes.LightGray;

            DateTime date = (DateTime)value;

            TimeSpan difference = DateTime.Now - date;

            double days = difference.TotalDays;

            if (days < 0) 
            {
                return null;
            };

            switch ((int)days)
            {
                case 0:
                    return Brushes.Yellow;
                case >= 1:
                    return Brushes.Orange;
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
