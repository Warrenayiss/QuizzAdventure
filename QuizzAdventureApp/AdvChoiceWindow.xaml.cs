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
	/// Logique d'interaction pour AdvChoiceWindow.xaml
	/// </summary>
	public partial class AdvChoiceWindow : Window
	{
		public AdvChoiceWindow()
		{
			InitializeComponent();
		}

		private void backBtn_Click(object sender, RoutedEventArgs e)
		{
			HomeWindow window = new HomeWindow();
			window.Show();
			Close();
		}

		private void choiceBtn_Click(object sender, RoutedEventArgs e)
		{
			//TODO: Take the name of the clicked button to see if the quizz would be 5, 15 or 25 questions long

			GameWindow window = new GameWindow();
			window.Show();
			Close();
		}
	}
}
