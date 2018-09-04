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

namespace Wpf_Pegadaian.Forms
{
    public partial class Transaction : Window
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (cb_product.Text == "" || cb_installment_type.Text == "" || cb_outlet.Text == "" || txt_on_behalf_of.Text == "" || txt_administrative_cost.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                txt_administrative_cost.Focus();
                return;
            }
        }

        private void DataGridTransaction_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
