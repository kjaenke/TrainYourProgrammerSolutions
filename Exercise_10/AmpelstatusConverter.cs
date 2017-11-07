// ReSharper disable PossibleNullReferenceException
namespace Exercise_10
{
    using System;
    using System.Globalization;
    using System.Windows.Data;
    using System.Windows.Media;
    using static System.Windows.Media.ColorConverter;

    public class AmpelstatusConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var p = parameter as string;
            string[] farben = p.Split(';');

            var solidColorBrush = new SolidColorBrush();

            switch (value as string)
            {
                case "1":
                    solidColorBrush.Color = (Color) ConvertFromString(farben[0]);
                    break;
                case "2":
                    solidColorBrush.Color = (Color) ConvertFromString(farben[1]);
                    break;
                case "3":
                    solidColorBrush.Color = (Color) ConvertFromString(farben[2]);
                    break;
                default:
                    solidColorBrush.Color = (Color) ConvertFromString("White");
                    break;
            }
                                                      
            return solidColorBrush;
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}