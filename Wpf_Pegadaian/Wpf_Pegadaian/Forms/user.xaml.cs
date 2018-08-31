using System;
using System.Collections.Generic;
using Wpf_Pegadaian.Models;
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
    /// Interaction logic for user.xaml
    /// </summary>
    public partial class user : Window
    {
        PegadaianEntities dbbb = new PegadaianEntities();
        public user()
        {
            InitializeComponent();
            clear();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            simpan_user();
        }
        private void simpan_user()
        {
            USER user = new USER()
            {
                NAME = tname.Text,
                IDENTITY_TYPE = tidentity.Text,
                IDENTITY_NUMBER = tidentity_id.Text,
                GENDER = tgender.Text,
                BORN_PLACE = tbornplace.Text,
                BORN_DATE = Convert.ToDateTime(tborndate.Text),
                PROVINCE = tprovince.Text,
                REGENCY = tregency.Text,
                SUB_DISTRICT = tsubdis.Text,
                ADDRESS = taddress.Text,
                EMAIL = temail.Text,
                USERNAME = tusername.Text,
                PASSWORD = tpassword.Password,
                BANK_ACCOUNT = tbank.Text,
                ROLE_ID =Convert.ToInt32(troles.Text),
                NUMBER_NPWP = tnpwp.Text,
                PICTURE_NPWP = tpic_npwp.Text,
                PICTURE_IDENTITY = tpic_identity.Text
                
            };
            dbbb.USERs.Add(user);
            dbbb.SaveChanges();
            list_user.datagrid_user.ItemsSource = dbbb.USERs.ToList();
            this.Hide();
        }

        private void clear()
        {
            tname.Text = "";
            tidentity.Text = "";
            tidentity_id.Text = "";
            tgender.Text = "";
            tbornplace.Text = "";
            tborndate.Text = "";
            tprovince.Text = "";
            tregency.Text = "";
            tsubdis.Text = "";
            taddress.Text = "";
            temail.Text = "";
            tusername.Text = "";
            tpassword.Password =  "";
            tbank.Text = "";
            troles.Text = "";
            tnpwp.Text = "";
            tpic_npwp.Text = "";
            tpic_identity.Text = "";

        }
    }
}
