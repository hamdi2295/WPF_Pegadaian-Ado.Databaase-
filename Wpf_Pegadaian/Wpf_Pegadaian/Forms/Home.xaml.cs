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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Pegadaian.Forms
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        PegadaianEntities _db = new PegadaianEntities();
        public static DataGrid datagrid;  

        public Home()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            MydataGrid.ItemsSource = _db.GOLDs.ToList();
            datagrid = MydataGrid;
            
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            golds gg = new golds();
            gg.ShowDialog();
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            int id = (MydataGrid.SelectedItem as GOLD).ID;
            update_golds update = new update_golds(id);


            update.ShowDialog();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            int id = (MydataGrid.SelectedItem as GOLD).ID;
            var deletegold = _db.GOLDs.Where(m => m.ID == id).Single();
            _db.GOLDs.Remove(deletegold);
            _db.SaveChanges();
            MydataGrid.ItemsSource = _db.GOLDs.ToList();
        }
    }
}
