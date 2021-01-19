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
	/// Logique d'interaction pour AddQuestionWindow.xaml
	/// </summary>
	public partial class AddQuestionWindow : Window
	{
		public AddQuestionWindow()
		{
			InitializeComponent();
			
		}
		

		private void saveBtn_Click(object sender, RoutedEventArgs e)
		{
			//TODO: get the input to create a new question
			Close();
		}


		private void Add_Closed(object sender, EventArgs e)
		{
			HomeWindow window = new HomeWindow();
			window.Show();
		}
	}
}
