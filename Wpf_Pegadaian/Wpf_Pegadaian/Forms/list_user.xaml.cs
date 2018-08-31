using System;
using Wpf_Pegadaian.Models;
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
    /// Interaction logic for list_user.xaml
    /// </summary>
    public partial class list_user : Window
    {
        PegadaianEntities _db = new PegadaianEntities();
        public static DataGrid datagrid_user;
        public list_user()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            DataGridUser.ItemsSource = _db.USERs.ToList();
            datagrid_user = DataGridUser;

        }



        private void updateuserBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void deleteuserBtn_Click(object sender, RoutedEventArgs e)
        {
            int id = (DataGridUser.SelectedItem as USER).ID;
            var deleteuser = _db.USERs.Where(m => m.ID == id).Single();
            _db.USERs.Remove(deleteuser);
            _db.SaveChanges();
            DataGridUser.ItemsSource = _db.USERs.ToList();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            user u = new user();
            u.ShowDialog();
        }

        private void DataGridUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
