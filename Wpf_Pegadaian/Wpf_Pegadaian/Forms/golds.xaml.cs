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
    /// Interaction logic for golds.xaml
    /// </summary>
    public partial class golds : Window
    {
        PegadaianEntities db = new PegadaianEntities();
        
        public golds()
        {
            InitializeComponent();
   
        }

       
        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            GOLD emas = new GOLD()
            {
                TYPE = ttype.Text,
                UNIT = tunit.Text,
                SELLING_PRICE = Convert.ToInt32(tselling.Text),
                PURCHASE_PRICE = Convert.ToInt32(tpurchase.Text)
            };
            db.GOLDs.Add(emas);
            db.SaveChanges();
            Home.datagrid.ItemsSource = db.GOLDs.ToList();
            this.Hide();

        }
        
       
    }
}
