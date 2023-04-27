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
using WpfApp1.Model;

namespace WpfApp1.Forms
{
    /// <summary>
    /// Логика взаимодействия для GameWindows.xaml
    /// </summary>
    public partial class GameWindows : Window
    {
        Model.Gamer Gamer;
        public GameWindows()
        {
            InitializeComponent();
            Gamer = App.myGamer;
            gridInfoGamer.DataContext = Gamer;         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int age = Gamer.Age;
            Gamer.Age = age + 1;
            gridInfoGamer.DataContext = null;
            gridInfoGamer.DataContext = Gamer;
        }

        private void btWork_Click(object sender, RoutedEventArgs e)
        {
            Forms.WorkListWindows work = new WorkListWindows();
            work.ShowDialog();
            gridInfoGamer.DataContext = null;
            gridInfoGamer.DataContext = Gamer;
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            Gamer newGamer = new Gamer();
            newGamer.Subject = Gamer.Subject;
            newGamer.DateCreate = Gamer.DateCreate;
            newGamer.Experience = Gamer.Experience;     
            newGamer.Age = Gamer.Age;
            newGamer.Work = Gamer.Work;

            App.myGamerList.Add(newGamer);
        }
    }
}
