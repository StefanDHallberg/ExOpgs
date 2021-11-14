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

namespace WPFSimpleGUI
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
        private void upButton_Click(object sender, RoutedEventArgs e)
        {
            //Next();
            string value = tb1.Text;
            tb1.Text = tb2.Text;
            tb2.Text = tb3.Text;
            tb3.Text = tb4.Text;
            tb4.Text = value;
        }
        private void downButton_Click(object sender, RoutedEventArgs e)
        {
            //Prev();
            string value = tb1.Text;
            tb1.Text = tb4.Text;
            tb4.Text = tb3.Text;
            tb3.Text = tb2.Text;
            tb2.Text = value;
        }

        private void tb1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        private void tb2_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void tb3_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void tb4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            tb4.Text = "";
        }
    }
}
