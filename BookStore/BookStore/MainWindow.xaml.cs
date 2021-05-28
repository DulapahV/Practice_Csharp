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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataAccess.InitializeDatabase();
        }

        private void txtBox_userUsername_GotMouseCapture(object sender, MouseEventArgs e)
        {
            // Check if text field is default value, if not then do not clear the value
            if (txtBox_userUsername.Text == "Username")
            {
                txtBox_userUsername.Clear();
            }
        }

        private void txtBox_userUsername_LostFocus(object sender, RoutedEventArgs e)
        {
            // Check if user input anything, if not then display default value
            if (txtBox_userUsername.Text == "")
            {
                txtBox_userUsername.Text = "Username";
            }
        }

        private void txtBox_userPassword_GotMouseCapture(object sender, MouseEventArgs e)
        {
            // Check if text field is default value, if not then do not clear the value
            if (txtBox_userPassword.Password == "Password")
            {
                txtBox_userPassword.Clear();
            }
        }

        private void txtBox_userPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            // Check if user input anything, if not then display default value
            if (txtBox_userPassword.Password == "")
            {
                txtBox_userPassword.Password = "Password";
            }
        }

        private void txtBox_newUsername_GotMouseCapture(object sender, MouseEventArgs e)
        {
            // Check if text field is default value, if not then do not clear the value
            if (txtBox_newUsername.Text == "Username")
            {
                txtBox_newUsername.Clear();
            }
        }

        private void txtBox_newUsername_LostFocus(object sender, RoutedEventArgs e)
        {
            // Check if user input anything, if not then display default value
            if (txtBox_newUsername.Text == "")
            {
                txtBox_newUsername.Text = "Username";
            }
        }

        private void txtBox_newPassword_GotMouseCapture(object sender, MouseEventArgs e)
        {
            // Check if text field is default value, if not then do not clear the value
            if (txtBox_newPassword.Password == "Password")
            {
                txtBox_newPassword.Clear();
            }
        }

        private void txtBox_newPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            // Check if user input anything, if not then display default value
            if (txtBox_newPassword.Password == "")
            {
                txtBox_newPassword.Password = "Password";
            }
        }
        private void txtBox_newPasswordConfirm_GotMouseCapture(object sender, MouseEventArgs e)
        {
            // Check if text field is default value, if not then do not clear the value
            if (txtBox_newPasswordConfirm.Password == "Password")
            {
                txtBox_newPasswordConfirm.Clear();
            }
        }

        private void txtBox_newPasswordConfirm_LostFocus(object sender, RoutedEventArgs e)
        {
            // Check if user input anything, if not then display default value
            if (txtBox_newPasswordConfirm.Password == "")
            {
                txtBox_newPasswordConfirm.Password = "Password";
            }
        }

        private void txtBox_adminUsername_GotMouseCapture(object sender, MouseEventArgs e)
        {
            // Check if text field is default value, if not then do not clear the value
            if (txtBox_adminUsername.Text == "Username")
            {
                txtBox_adminUsername.Clear();
            }
        }

        private void txtBox_adminUsername_LostFocus(object sender, RoutedEventArgs e)
        {
            // Check if user input anything, if not then display default value
            if (txtBox_adminUsername.Text == "")
            {
                txtBox_adminUsername.Text = "Username";
            }
        }

        private void txtBox_adminPassword_GotMouseCapture(object sender, MouseEventArgs e)
        {
            // Check if user input anything, if not then display default value
            if (txtBox_adminPassword.Password == "Password")
            {
                txtBox_adminPassword.Clear();
            }
        }

        private void txtBox_adminPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            // Check if user input anything, if not then display default value
            if (txtBox_adminPassword.Password == "")
            {
                txtBox_adminPassword.Password = "Password";
            }
        }

        private void btn_register_Click(object sender, RoutedEventArgs e)
        {
            List<string> getData = DataAccess.GetData();

            // Check if user enter all the field
            if (txtBox_newUsername.Text == "Username" || txtBox_newPassword.Password == "Password" || txtBox_newPasswordConfirm.Password == "Password")
            {
                MessageBox.Show("Please fill in all the fields!");
            }

            // Check if password matches with confirm password
            else if (txtBox_newPassword.Password != txtBox_newPasswordConfirm.Password)
            {
                MessageBox.Show("Password does not match!");
            }
            else
            {
                MessageBox.Show("Success");
                DataAccess.AddData(txtBox_newUsername.Text, txtBox_newPassword.Password);

                string textResult = "";
                for (int i = 0; i < getData.Count; i++)
                {
                    textResult += getData[i] + "\n";
                }

                MessageBox.Show(textResult);
            }
        }

        private void btn_userLogin_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
