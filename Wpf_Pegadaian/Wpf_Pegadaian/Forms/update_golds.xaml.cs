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
    /// Interaction logic for update_golds.xaml
    /// </summary>
    public partial class update_golds : Window
    {
        PegadaianEntities db = new PegadaianEntities();
        int id;
        public update_golds(int goldid)
        {
            InitializeComponent();
            clear();
            id = goldid;

        }
        private void UpdateGold()
        {
            GOLD updategold = (from g in db.GOLDs
                               where g.ID == id
                               select g).Single();
            
            ttype.Text = "" + updategold.TYPE;
            tunit.Text = "" + updategold.UNIT;
            tselling.Text = "" + updategold.SELLING_PRICE;
            tpurchase.Text = "" + updategold.PURCHASE_PRICE;

            updategold.TYPE = ttype.Text;
            updategold.UNIT = tid.Text;
            updategold.SELLING_PRICE = Convert.ToInt32(tselling.Text);
            updategold.PURCHASE_PRICE = Convert.ToInt32(tpurchase.Text);

            db.SaveChanges();
            Home.datagrid.ItemsSource = db.GOLDs.ToList();
            this.Hide();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            UpdateGold();
        }

        private void clear()
        {
            tid.Text = "";
            ttype.Text = "";
            tunit.Text = "";
            tselling.Text = "";
            tpurchase.Text = "";
        }
    }
}
