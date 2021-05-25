using System;
using System.Collections;
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

namespace Hashmap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            hashtable = new Hashtable();
            InitializeComponent();
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            // Add
            hashtable.Add(txtKey.Text, txtValue.Text);
        }

        private void button_remove_Click(object sender, RoutedEventArgs e)
        {
            // Remove
            hashtable.Remove(txtKey.Text);
        }

        private void button_showAll_Click(object sender, RoutedEventArgs e)
        {
            ICollection icollection = hashtable.Keys;
            // Show data
            foreach (string key in icollection)
            {
                MessageBox.Show(hashtable[key].ToString());
            }
        }
    }
}
