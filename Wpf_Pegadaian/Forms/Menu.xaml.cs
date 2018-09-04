using System;
using System.Collections.Generic;
using Wpf_Pegadaian.Models;
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

namespace Wpf_Pegadaian.Forms
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        
        public Menu()
        {
            InitializeComponent();
            
        }

        private void button1_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            login log = new login();
            log.ShowDialog();
         
        }

        private void btn_User_Click(object sender, RoutedEventArgs e)
        {
            Forms.list_user lu = new Forms.list_user();
            lu.ShowDialog();
        }
    }
}
