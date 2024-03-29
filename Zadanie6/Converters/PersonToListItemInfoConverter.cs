﻿using System;
using System.Globalization;
using System.Text;
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

            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"{person.Name} {person.Surname}");
            if (!string.IsNullOrEmpty(person.Email))
            {
                stringBuilder.Append($"({person.Email})");
            }

            return stringBuilder.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
