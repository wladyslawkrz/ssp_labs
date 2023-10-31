using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Lab4_Bindings
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
	}

	public class FontSizeConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			double fontSize = System.Convert.ToDouble(value);

			if (parameter as string == "Inverse")
			{
				return fontSize;
			}

			return Math.Round(fontSize, 0);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			string text = (string)value;

			if (double.TryParse(text, out double fontSize))
			{
				return fontSize;
			}

			return 0.0;
		}
	}
}