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
	/// Logique d'interaction pour GameWindow.xaml
	/// </summary>
	public partial class GameWindow : Window
	{
		public GameWindow()
		{
			InitializeComponent();
			questionLb.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean tincidunt malesuada auctor. Aenean elementum, dui sed ultrices commodo, orci eros faucibus magna, a facilisis nisl diam in magna. Pellentesque mollis lobortis elit eget lacinia. Morbi pharetra leo id hendrerit sodales. Vivamus pellentesque eros sed mi porttitor volutpat.";
		}

	}
}
