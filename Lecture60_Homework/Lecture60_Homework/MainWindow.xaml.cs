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

namespace Lecture60_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_calculate_Click(object sender, RoutedEventArgs e)
        {
            int difference = int.Parse(inputIncome.Text) - int.Parse(inputExpense.Text);
            int result = int.Parse(inputCost.Text) / difference;
            resultDays.Text = result.ToString();
        }
    }
}
