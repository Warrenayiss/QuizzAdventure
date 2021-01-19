using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuizzAdventureApp
{
	/// <summary>
	/// Logique d'interaction pour GameFailWindow.xaml
	/// </summary>
	public partial class GameFailWindow : Window
	{
		public GameFailWindow()
		{
			InitializeComponent();
		}

		private void mainBtn_Click(object sender, RoutedEventArgs e)
		{
			HomeWindow window = new HomeWindow();
			window.Show();
			Close();
		}
	}
}
