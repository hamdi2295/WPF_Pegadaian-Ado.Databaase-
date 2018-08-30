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
    /// Interaction logic for golds.xaml
    /// </summary>
    public partial class golds : Window
    {
        Models.pegadaianEntities2 _db = new Models.pegadaianEntities2();
        
        public golds()
        {
            InitializeComponent();
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Models.GOLD newgold = new Models.GOLD()
            {
                TYPE = ttype.Text,
                UNIT = tunit.Text
                
            };
            _db.GOLDs.Add(newgold);
            _db.SaveChanges();

        }
        
    }
}
