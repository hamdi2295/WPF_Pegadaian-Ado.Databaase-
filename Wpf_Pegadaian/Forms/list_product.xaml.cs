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
    public partial class list_product : Window
    {
        public list_product()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                txt_name.Focus(); // set focus to lastNameTextBox
                return;
            }
        }

        private void txt_name_TextChanged(object sender, TextChangedEventArgs e)
        {
            string input = (sender as TextBox).Text;
            if (input.Count() > 30)
            {
                MessageBox.Show("Name is too long! (maximum length is 30 character)");
            }
        }

        private void DataGridProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
