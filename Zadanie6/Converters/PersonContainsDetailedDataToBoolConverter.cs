using System;
using System.Globalization;
using System.Windows.Data;
using Zadanie6.Extensions;

namespace Zadanie6.Converters
{
    public class PersonContainsDetailedDataToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not Person person)
            {
                return false;
            }

            return !person.Email.IsNullOrEmpty() || (person.Region is not null) ||
                   (person.Deposit.HasValue && person.Deposit.Value != 0) || person.AccessLevel != 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
