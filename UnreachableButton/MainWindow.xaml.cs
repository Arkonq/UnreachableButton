using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UnreachableButton
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Grid_MouseMove(object sender, MouseEventArgs e)
		{
			Thickness thickness = button.Margin;

			Random random = new Random();

			int side = random.Next(4);

			switch (side)
			{
				case 0:
					thickness.Left += 66;
					button.Margin = thickness;
					break;
				case 1:
					thickness.Top += 66;
					button.Margin = thickness;
					break;
				case 2:
					thickness.Left -= 66;
					button.Margin = thickness;
					break;
				case 3:
					thickness.Top -= 66;
					button.Margin = thickness;
					break;
			}

			if (button.Margin.Left < 50)
			{
				thickness.Left = 50;
				button.Margin = thickness;
			}
			if ((button.Margin.Left + button.Width) > this.Width - 50)
			{
				thickness.Left = this.Width - button.Width - 50;
				button.Margin = thickness;
			}
			if (button.Margin.Top < 50)
			{
				thickness.Top = 50;
				button.Margin = thickness;
			}
			if ((button.Margin.Top + button.Height) > this.Height - 50)
			{
				thickness.Top = this.Height - button.Height - 50;
				button.Margin = thickness;
			}
		}

		private void buttonClicked(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Вот это поворот!");
		}
	}
}
