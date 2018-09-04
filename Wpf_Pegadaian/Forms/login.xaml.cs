using System;
using Wpf_Pegadaian.Models;
using Wpf_Pegadaian.Controllers;
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

namespace Wpf_Pegadaian.Forms
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        PegadaianEntities1 _db = new PegadaianEntities1();
        public login()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            loginn();
        }
        
        private void loginn()
        {
            Login log = new Login();
               
            if (log.cekLogin(username.Text, password.Password) == true)
            {
                MessageBox.Show("Login Berhasil", "Peringatan", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Hide();
                Menu m = new Menu();
                m.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username and Password not match", "Peringatan", MessageBoxButton.OK, MessageBoxImage.Warning);
                password.Clear();
                password.Focus();
            }
        }
    }
}
