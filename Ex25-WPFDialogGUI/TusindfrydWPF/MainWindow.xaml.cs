using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace TusindfrydWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<FlowerSort> flowerSorts;
        public MainWindow()
        {
            InitializeComponent();
            flowerSorts = new List<FlowerSort>();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            CreateFlowerSortDialog createFlowerSortDialog = new CreateFlowerSortDialog();
            if(createFlowerSortDialog.ShowDialog() == true)
            {
                flowerSorts.Add(createFlowerSortDialog.CurrentFlowerSort);

                BlomstersortTB.Text = "";
                foreach (var flowersort in flowerSorts)
                {
                    BlomstersortTB.Text += flowersort.Name + "\n";
                }

            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

               // flowerSorts.Remove();
                
                
                //BlomstersortTB.Text = "";
                //foreach (var flowersort in flowerSorts)
                //{
                //    BlomstersortTB.Text = flowersort.Name + "\n";
                //}
            
        }
    }
}
