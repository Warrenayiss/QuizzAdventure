using QuizzAdventureApp.Windows;
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
	/// Logique d'interaction pour HighscoreWindow.xaml
	/// </summary>
	public partial class HighscoreWindow : Window
	{
		public HighscoreWindow()
		{
			InitializeComponent();
		}

		private void menu_Click(object sender, RoutedEventArgs e)
		{
			HomeWindow window = new HomeWindow();
			window.Show();
			Close();

		}
	}
}
