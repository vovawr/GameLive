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
using System.Windows.Shapes;

namespace WpfApp1.Forms
{
    public partial class RunGameWindows : Window
    {
        public RunGameWindows()
        {
            InitializeComponent();

            dtListgame.ItemsSource = App.myGamerList;
        }

        private void btrunGame_Click(object sender, RoutedEventArgs e)
        {
            App.myGamer = dtListgame.SelectedItem as Model.Gamer;  
        
            GameWindows gameWindows = new GameWindows();
            gameWindows.Show();
            Close();
        }
    }
}
