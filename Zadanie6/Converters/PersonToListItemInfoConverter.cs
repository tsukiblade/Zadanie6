using System;
using System.Globalization;
using System.Windows.Data;

namespace Zadanie6.Converters
{
    public class PersonToListItemInfoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not Person person)
            {
                return value; //dont throw, just return value :)
            }

            return $"{person.Name} {person.Surname} ({person.Email})";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
