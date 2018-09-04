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
    /// <summary>
    /// Interaction logic for list_barang.xaml
    /// </summary>
    public partial class Installment : Window
    {
        public Installment()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (dt_due_date.Text == "" || dt_installment_date.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                dt_installment_date.Focus();
                return;
            }
        }

        private void DataGridInstallment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
