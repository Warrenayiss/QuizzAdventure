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

namespace QuizzAdventureApp.Windows
{
	/// <summary>
	/// Logique d'interaction pour HomeWindow.xaml
	/// </summary>
	public partial class HomeWindow : Window
	{
		public HomeWindow()
		{
			InitializeComponent();
		}

		private void exitBtn_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void playBtn_Click(object sender, RoutedEventArgs e)
		{
			AdvChoiceWindow window = new AdvChoiceWindow();
			window.Show();
			Close();
		}

		private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			CodeWindow window = new CodeWindow();
			window.Show();
			Close();
		}

		private void highscoreBtn_Click(object sender, RoutedEventArgs e)
		{
			HighscoreWindow window = new HighscoreWindow();
			window.Show();
			Close();
		}
	}
}
