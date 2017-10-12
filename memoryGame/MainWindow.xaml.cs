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

namespace memoryGame
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

		private void level1Btn_Click(object sender, RoutedEventArgs e)
		{
			var win = new Level1();
			win.Show();
			this.Close();
		}

		private void level2Btn_Click(object sender, RoutedEventArgs e)
		{
			var win = new Level2();
			win.Show();
			this.Close();
		}

		private void level99Btn_Click(object sender, RoutedEventArgs e)
		{
			var win = new Level99();
			win.Show();
			this.Close();
		}

		private void closeBtn_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

        private void leaderboardBtn_Click(object sender, RoutedEventArgs e)
        {
            var win = new Leaderboard();
            win.Show();
            this.Close();
        }
    }
}
