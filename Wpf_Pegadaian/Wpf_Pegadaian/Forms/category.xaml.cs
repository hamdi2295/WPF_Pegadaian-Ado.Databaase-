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
    /// Interaction logic for category.xaml
    /// </summary>
    public partial class category : Window
    {
        PegadaianEntities _db = new PegadaianEntities();
        public static DataGrid datagrid_category;
        public category()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            DataGridCategory.ItemsSource = _db.CATEGORies.ToList();
            datagrid_category = DataGridCategory;

        }

        private void hapus()
        {
            int id = (DataGridCategory.SelectedItem as CATEGORY).ID;
            var deletecategory = _db.CATEGORies.Where(m => m.ID == id).Single();
            _db.CATEGORies.Remove(deletecategory);
            _db.SaveChanges();
            DataGridCategory.ItemsSource = _db.CATEGORies.ToList();
        }

        private void simpan_category()
        {
            CATEGORY cat = new CATEGORY()
            {
                NAME = tname.Text
                
            };
            _db.CATEGORies.Add(cat);
            _db.SaveChanges();
            datagrid_category.ItemsSource = _db.CATEGORies.ToList();
            
        }

        private void tampildata()
        {
            
        }

        private void deletecategoryBtn_Click(object sender, RoutedEventArgs e)
        {
            hapus();
        }

        private void btnsimpan_Click(object sender, RoutedEventArgs e)
        {
            simpan_category();
        }
    }
}
