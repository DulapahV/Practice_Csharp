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

namespace ArrayListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            // Add data
            arrayList.Add(int.Parse(txtInput.Text));
        }

        private void button_remove_Click(object sender, RoutedEventArgs e)
        {
            // Search for all matching data then remove
            for (int i = 0; i < arrayList.Count; i++)
            {
                arrayList.Remove(int.Parse(txtInput.Text));
            }
        }

        private void button_showAll_Click(object sender, RoutedEventArgs e)
        {
            // Show data
            arrayList.Sort();
            foreach (int data in arrayList)
            {
                MessageBox.Show(data.ToString());
            }
        }
    }
}
