using System.Globalization;

namespace MauiFontIssue;

public class EqualsMultiValueConverter : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        if (values.Length < 2)
        {
            return true;
        }

        for (int i = 1; i < values.Length; i++)
        {
            if (!values[i].Equals(values[0]))
            {
                return false;
            }
        }

        return true;
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
