using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Lab3
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void ChangeBackgroundColor_Click(object sender, RoutedEventArgs e)
		{
			var rand = new Random();
			var randomColor = Color.FromRgb((byte)rand.Next(256), (byte)rand.Next(256), (byte)rand.Next(256));
			Background = new SolidColorBrush(randomColor);

			StatusText.Content = "Цвет изменен на:  " + randomColor;
		}

		private void About_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Разработано студентом группы АСОИ-201, Кветковским Владиславом Игоревичем");
		}

		private void Exit_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void ToolBarButton_MouseEnter(object sender, RoutedEventArgs e)
		{
			StatusText.Content = ((Button)sender).Content;
		}

		private void ToolBarButton_MouseLeave(object sender, RoutedEventArgs e)
		{
			StatusText.Content = string.Empty;
		}

		private void MenuItem_LostFocus(object sender, RoutedEventArgs e)
		{
			StatusText.Content = string.Empty;
		}

		private void MenuItem_GotFocus(object sender, RoutedEventArgs e)
		{
			StatusText.Content = ((MenuItem)sender).Header;
		}
	}
}