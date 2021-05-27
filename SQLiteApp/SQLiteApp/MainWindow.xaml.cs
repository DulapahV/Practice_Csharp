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

namespace SQLiteApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string textResult = "";
            List<string> getData = DataAccess.GetData();
            for (int i = 0; i < getData.Count; i++)
            {
                textResult += getData[i] + "\n";
            }
            MessageBox.Show(textResult);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DataAccess.AddData(firstNameBox.Text, lastNameBox.Text, emailBox.Text);
            firstNameBox.Text = lastNameBox.Text = emailBox.Text = "";
        }
    }
}