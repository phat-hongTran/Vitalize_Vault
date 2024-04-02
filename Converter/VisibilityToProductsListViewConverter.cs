using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using Vitalize_Vault.ViewModel;

namespace Vitalize_Vault.Converter
{
    public class VisibilityToProductsListViewConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var products = value as List<ProductItemViewModel>;
            if (products != null)
            {
                if (!products.Any()) 
                {
                    return Visibility.Hidden;
                }
            }
            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
