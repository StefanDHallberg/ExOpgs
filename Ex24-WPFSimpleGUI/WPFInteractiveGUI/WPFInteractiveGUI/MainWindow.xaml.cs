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

namespace WPFInteractiveGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Controller controller;
        public MainWindow()
        {
            InitializeComponent();

            controller = new Controller();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            controller.AddPerson();
            PersonCountNo.Content = controller.PersonCount;
            IndexNo.Content = controller.PersonIndex;
            if (controller.PersonCount <= 1)
            {
                tb1.IsEnabled = true;
                tb2.IsEnabled = true;
                tb3.IsEnabled = true;
                tb4.IsEnabled = true;
                DeletePerson.IsEnabled = true;
                Up.IsEnabled = true;
                Down.IsEnabled = true;
            }
        }
        private void DeletePerson_Click(object sender, RoutedEventArgs e)
        {if (controller.PersonCount > 0)
            {
               tb1.Text = controller.CurrentPerson.FirstName;
               tb2.Text = controller.CurrentPerson.LastName;
               tb3.Text = controller.CurrentPerson.Age.ToString();
               tb4.Text = controller.CurrentPerson.TelephoneNo;
               IndexNo.Content = controller.PersonIndex;
            }
        else 
            {
                tb1.Text = " ";
                tb2.Text = " ";
                tb3.Text = " ";
                tb4.Text = " ";
                IndexNo.Content = "-1";
                tb1.IsEnabled = false;
                tb2.IsEnabled = false;
                tb3.IsEnabled = false;
                tb4.IsEnabled = false;
                DeletePerson.IsEnabled = false;
                Up.IsEnabled = false;
                Down.IsEnabled = false;
            }
        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            controller.NextPerson();
            tb1.Text = controller.CurrentPerson.FirstName;
            tb2.Text = controller.CurrentPerson.LastName;
            tb3.Text = controller.CurrentPerson.Age.ToString();
            tb4.Text = controller.CurrentPerson.TelephoneNo;
            IndexNo.Content = controller.PersonIndex;
        }

        private void Down_Click(object sender, RoutedEventArgs e)
        {
            controller.PrevPerson();
            tb1.Text = controller.CurrentPerson.FirstName;
            tb2.Text = controller.CurrentPerson.LastName;
            tb3.Text = controller.CurrentPerson.Age.ToString();
            tb4.Text = controller.CurrentPerson.TelephoneNo;
            IndexNo.Content = controller.PersonIndex;
        }

        private void tb1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (controller.PersonCount > 0)
            {
                controller.CurrentPerson.FirstName = tb1.Text;
            }
        }

        private void tb2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (controller.PersonCount > 0)
            {
                controller.CurrentPerson.LastName = tb2.Text;
            }
        }

        private void tb3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (controller.PersonCount > 0)
            {
                controller.CurrentPerson.Age = Convert.ToInt32(tb3.Text);
            }
        }

        private void tb4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (controller.PersonCount > 0)
            {
                controller.CurrentPerson.TelephoneNo = tb4.Text;
            }
        }
    }
}
