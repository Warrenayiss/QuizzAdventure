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
	/// Logique d'interaction pour CodeWindow.xaml
	/// </summary>
	public partial class CodeWindow : Window
	{
		public CodeWindow()
		{
			InitializeComponent();
		}

		private void Go_Click(object sender, RoutedEventArgs e)
		{
			//TODO; Verify if the text inputed correspond to the secret code

			AddQuestionWindow window = new AddQuestionWindow();
			window.ShowDialog();
			Close();
		}
	}
}
