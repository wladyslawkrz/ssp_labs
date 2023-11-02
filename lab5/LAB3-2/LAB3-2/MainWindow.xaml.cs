using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Lab3_2
{
	public partial class MainWindow : Window
	{
		private SolidColorBrush currentBrush = new SolidColorBrush(Colors.Black);

		public MainWindow()
		{
			InitializeComponent();
		}

		private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			ComboBoxItem selectedItem = (ComboBoxItem)ColorComboBox.SelectedItem;
			currentBrush = (SolidColorBrush)selectedItem.Foreground;
			inkCanvas.DefaultDrawingAttributes.Color = currentBrush.Color;
		}

		private void DrawRadioButton_Checked(object sender, RoutedEventArgs e)
		{
			inkCanvas.EditingMode = InkCanvasEditingMode.Ink;
		}

		private void EditRadioButton_Checked(object sender, RoutedEventArgs e)
		{
			inkCanvas.EditingMode = InkCanvasEditingMode.Select;
		}

		private void DeleteRadioButton_Checked(object sender, RoutedEventArgs e)
		{
			inkCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
		}

		private void SizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			inkCanvas.DefaultDrawingAttributes.Width = SizeSlider.Value;
			inkCanvas.DefaultDrawingAttributes.Height = SizeSlider.Value;
		}
	}
}