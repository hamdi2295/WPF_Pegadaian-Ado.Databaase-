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
    public partial class list_outlet : Window
    {
        public list_outlet()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txt_name.Text == "" || txt_province.Text == "" || txt_regency.Text == "" || txt_subdistrict.Text == "" || txt_address.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                txt_address.Focus(); // set focus to lastNameTextBox
                return;
            }
        }

        private void txt_name_TextChanged(object sender, TextChangedEventArgs e)
        {
            string input = (sender as TextBox).Text; //1234567
            if (input.Count() > 30)
            {
                MessageBox.Show("Name is too long! (maximum length is 30 character)");
            }
        }

        private void DataGridOutlet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
