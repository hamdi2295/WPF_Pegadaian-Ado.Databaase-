using System;
using Wpf_Pegadaian.Models;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for list_user.xaml
    /// </summary>
    public partial class list_user : Window
    {
        PegadaianEntities1 _db = new PegadaianEntities1();

        int id;
        public list_user()
        {
            InitializeComponent();
            Load();
            clear_role();
            clear_user();
            combo_role();
            
        }
        private void Load()
        {
            dataGridUser.ItemsSource = _db.USERs.ToList();
            dataGridRole.ItemsSource = _db.ROLEs.ToList();          

        }

        private void combo_role()
        {            
            crole.ItemsSource = _db.ROLEs.ToList();
        }

        private void clear_role()
        {
            tr_name.Text = "";
        }

        private void clear_user()
        {
            tu_name.Text = "";
            tu_identiytype.Text = "";
            tu_identitynumber.Text = "";
            tu_gender.Text = "";
            tu_bornplace.Text = "";
           
            tu_province.Text = "";
            tu_regency.Text = "";
            tu_subdistrict.Text = "";
            tu_address.Text = "";
            tu_email.Text = "";
            tu_username.Text = "";
            tu_password.Text = "";
            tu_bankaccount.Text = "";
            
            tu_numbernpwp.Text = "";
            tu_picturenpwp.Text = "";
            tu_pictureidentity.Text = "";

        }

        private void updateuserBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        
        private void hapus_user()
        {
            int id = (dataGridUser.SelectedItem as USER).ID;
            var deleteuser = _db.USERs.Where(m => m.ID == id).Single();
            _db.USERs.Remove(deleteuser);
            _db.SaveChanges();
            dataGridUser.ItemsSource = _db.USERs.ToList();
        }

        

        private void DataGridUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dataGridRole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = dataGridRole.SelectedItem;
                string Nama = (dataGridRole.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                tr_name.Text = Nama;
            }
            catch (Exception ex)
            {

            }
            
        }

        private void simpan_role()
        {
            ROLE role = new ROLE()
            {
                NAME = tr_name.Text,
                
            };
            _db.ROLEs.Add(role);
            _db.SaveChanges();
            dataGridRole.ItemsSource = _db.ROLEs.ToList();
        }
        private void delete_role()
        {
            object item = dataGridRole.SelectedItem;
            string role_id = (dataGridRole.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

            int id = Convert.ToInt32(role_id);

            ROLE role = SearchByIdRole(id);
            _db.Entry(role).State = System.Data.Entity.EntityState.Deleted;
            _db.SaveChanges();
            dataGridRole.ItemsSource = _db.ROLEs.ToList();
        }
        private void UpdateRole()
        {
            object item = dataGridRole.SelectedItem;
            string role_id = (dataGridRole.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

            int id = Convert.ToInt32(role_id);

            ROLE role = SearchByIdRole (id);
            role.NAME = tr_name.Text;
            
            _db.Entry(role).State = System.Data.Entity.EntityState.Modified;           
            _db.SaveChanges();
            dataGridRole.ItemsSource = _db.ROLEs.ToList();
           
        }

        private void simpan_user()
        {
          
                USER user = new USER()
                {
                    NAME = tu_name.Text,
                    IDENTITY_TYPE = tu_identiytype.Text,
                    IDENTITY_NUMBER = tu_identitynumber.Text,
                    GENDER = tu_gender.Text,
                    BORN_PLACE = tu_bornplace.Text,
                    BORN_DATE = Convert.ToDateTime(tu_borndate.Text),
                    PROVINCE = tu_province.Text,
                    REGENCY = tu_regency.Text,
                    SUB_DISTRICT = tu_subdistrict.Text,
                    ADDRESS = tu_address.Text,
                    EMAIL = tu_email.Text,
                    USERNAME = tu_username.Text,
                    PASSWORD = tu_password.Text,
                    BANK_ACCOUNT = tu_bankaccount.Text,
                    ROLE_ID = Convert.ToInt32(tu_role.Text),
                    NUMBER_NPWP = tu_numbernpwp.Text,
                    PICTURE_NPWP = tu_picturenpwp.Text,
                    PICTURE_IDENTITY = tu_pictureidentity.Text

                };
                _db.USERs.Add(user);
                _db.SaveChanges();
                dataGridUser.ItemsSource = _db.USERs.ToList();
            
        }


        private void UpdateUser()
        {
            object item = dataGridUser.SelectedItem;
            string user_id = (dataGridUser.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

            int id = Convert.ToInt32(user_id);

            USER user = SearchByIdUser(id);
            user.NAME = tu_name.Text;
            user.IDENTITY_TYPE = tu_identiytype.Text;
            user.IDENTITY_NUMBER = tu_identitynumber.Text;
            user.GENDER = tu_gender.Text;
            user.BORN_PLACE = tu_bornplace.Text;
            user.BORN_DATE = Convert.ToDateTime(tu_borndate.Text);
            user.PROVINCE = tu_province.Text;
            user.REGENCY = tu_regency.Text;
            user.SUB_DISTRICT = tu_subdistrict.Text;
            user.ADDRESS = tu_address.Text;
            user.EMAIL = tu_email.Text;
            user.USERNAME = tu_username.Text;
            user.PASSWORD = tu_password.Text;
            user.BANK_ACCOUNT = tu_bankaccount.Text;
            user.ROLE_ID = Convert.ToInt32(tu_role.Text);
            user.NUMBER_NPWP = tu_numbernpwp.Text;
            user.PICTURE_NPWP = tu_picturenpwp.Text;
            user.PICTURE_IDENTITY = tu_pictureidentity.Text;

            _db.Entry(user).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
            dataGridUser.ItemsSource = _db.USERs.ToList();

        }

        private void deleteuser()
        {
            object item = dataGridUser.SelectedItem;
            string user_id = (dataGridUser.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;

            int id = Convert.ToInt32(user_id);

            USER user = SearchByIdUser(id);
            _db.Entry(user).State = System.Data.Entity.EntityState.Deleted;
            _db.SaveChanges();
            dataGridUser.ItemsSource = _db.USERs.ToList();
        }

        private void role_edit_Click(object sender, RoutedEventArgs e)
        {
            UpdateRole();
            clear_role();
        }

        private ROLE SearchByIdRole(int id)
        {

            var role = _db.ROLEs.Find(id);
            if (role == null)
            {
                MessageBox.Show("ID Role " + id + " tidak ditemukan", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            return role;
        }

        private USER SearchByIdUser(int id)
        {

            var user = _db.USERs.Find(id);
            if (user == null)
            {
                MessageBox.Show("ID User " + id + " tidak ditemukan", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            return user;
        }

        private void role_delete_Click(object sender, RoutedEventArgs e)
        {
            delete_role();
            clear_role();
        }

        private void role_save_Click(object sender, RoutedEventArgs e)
        {
            simpan_role();
            clear_role();
        }

        private void user_save_Click(object sender, RoutedEventArgs e)
        {
            simpan_user();
        }

        private void dataGridUser_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = dataGridUser.SelectedItem;
                string Name = (dataGridUser.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;   tu_name.Text = Name;
                string identity_type = (dataGridUser.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text; tu_identiytype.Text = identity_type;
                string identity_number = (dataGridUser.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text; tu_identitynumber.Text = identity_number;
                string gender = (dataGridUser.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text; tu_gender.Text = gender;
                string bornplace = (dataGridUser.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text; tu_bornplace.Text = bornplace;
                string borndate = (dataGridUser.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text; tu_borndate.Text = borndate;
                string province = (dataGridUser.SelectedCells[7].Column.GetCellContent(item) as TextBlock).Text; tu_province.Text = province;
                string regency = (dataGridUser.SelectedCells[8].Column.GetCellContent(item) as TextBlock).Text; tu_regency.Text = regency;
                string subdistrict = (dataGridUser.SelectedCells[9].Column.GetCellContent(item) as TextBlock).Text; tu_subdistrict.Text = subdistrict;
                string address = (dataGridUser.SelectedCells[10].Column.GetCellContent(item) as TextBlock).Text; tu_address.Text = address;
                string email = (dataGridUser.SelectedCells[11].Column.GetCellContent(item) as TextBlock).Text; tu_email.Text = email;
                string username = (dataGridUser.SelectedCells[12].Column.GetCellContent(item) as TextBlock).Text; tu_username.Text = username;
                string password = (dataGridUser.SelectedCells[13].Column.GetCellContent(item) as TextBlock).Text; tu_password.Text = password;
                string bankaccount = (dataGridUser.SelectedCells[14].Column.GetCellContent(item) as TextBlock).Text; tu_bankaccount.Text = bankaccount;
                string role = (dataGridUser.SelectedCells[15].Column.GetCellContent(item) as TextBlock).Text; tu_role.Text = role;
                string numbernpwp = (dataGridUser.SelectedCells[16].Column.GetCellContent(item) as TextBlock).Text; tu_numbernpwp.Text = numbernpwp;
                string piturenpwp = (dataGridUser.SelectedCells[17].Column.GetCellContent(item) as TextBlock).Text; tu_picturenpwp.Text = piturenpwp;
                string pictureidentity = (dataGridUser.SelectedCells[18].Column.GetCellContent(item) as TextBlock).Text; tu_pictureidentity.Text = pictureidentity;
            }
            catch (Exception ex)
            {

            }
        }

        private void user_edit_Click(object sender, RoutedEventArgs e)
        {
            UpdateUser();
            clear_user();
        }

        private void usr_delete_Click(object sender, RoutedEventArgs e)
        {
            deleteuser();
            clear_user();
        }
    }
}
