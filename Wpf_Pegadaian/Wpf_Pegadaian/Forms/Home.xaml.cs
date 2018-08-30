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
        pegadaianEntities1 _db = new pegadaianEntities1();
        public static DataGrid datagrid;

        public Home()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            dataGrid.ItemsSource = _db.golds.ToList();
            datagrid = dataGrid;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
