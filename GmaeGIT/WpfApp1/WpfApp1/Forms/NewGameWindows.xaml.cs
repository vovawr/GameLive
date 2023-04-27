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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace WpfApp1.Forms
{
   
    public partial class NewGameWindows : Window
    {
        public NewGameWindows()
        {
            InitializeComponent();

            List<string> genderList = new List<string> { "мужской", "женский" };
            List<string> subjectList = new List<string> { "програмирование" };

            cbGender.ItemsSource = genderList;
            cbSub.ItemsSource = subjectList; 
            cbGender.SelectedIndex = 0;
            cbSub.SelectedIndex = 0;    
        }
       
        private void btcreateGame_Click(object sender, RoutedEventArgs e)
        {
            Model.Gamer gamer = new Model.Gamer();
            
            gamer.Name = tbName.Text;
            gamer.Age = 22;
            gamer.Gender = cbGender.SelectedValue.ToString();
  
            gamer.Subject = cbSub.SelectedValue.ToString();

            gamer.DateCreate = DateTime.Now;
            App.myGamer = gamer;  
            
            Forms.GameWindows windows = new GameWindows();
            windows.Show();
            Close();    

        }
    }
}
