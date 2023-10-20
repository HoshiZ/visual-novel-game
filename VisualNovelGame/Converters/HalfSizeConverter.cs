using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;

namespace VisualNovelGame.Converters
{
	public class HalfSizeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double canvasSize = (double)value;
            double imageSize = (double)((FrameworkElement)parameter).ActualHeight; // or ActualWidth
            return (canvasSize - imageSize) / 2;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
