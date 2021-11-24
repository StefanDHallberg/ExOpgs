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
using System.Windows.Shapes;

namespace TusindfrydWPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class CreateFlowerSortDialog : Window
    {
        public FlowerSort CurrentFlowerSort;
        
        public CreateFlowerSortDialog()
        {
            InitializeComponent();
            CurrentFlowerSort = new FlowerSort();
        }

        private void NameTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void PicturePathTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            CurrentFlowerSort.PicturePath = PicturePathTB.Text;
        }
        
        private void PicturePathTB_LostFocus(object sender, RoutedEventArgs e) //Lost focus event
        {
            try
            { 
            //Uri resourceUri = new Uri("/Images/white_bengal_tiger.jpg", UriKind.Relative);
            Uri uri = new Uri(PicturePathTB.Text, UriKind.Absolute);  // C:\Users\Stefan H\Dropbox\1Datamatiker\Programmering\Ex25-WPFDialogGUI\TusindfrydWPF\bin\Debug\net5.0-windows
            FlowerSortImage.Source = new BitmapImage(uri);
            }
            catch (UriFormatException)
            {
                Console.WriteLine("Invalid path.");
            }
        }

        private void ProductionTimeTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void HalfLifeTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SizeTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            string empty = "";
            if (NameTB.Text != empty && ProductionTimeTB.Text != empty
                && HalfLifeTB.Text != empty && SizeTB.Text != empty)
            {
                Ok.IsEnabled = true;
                
            }
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            CurrentFlowerSort.Name = NameTB.Text;
            CurrentFlowerSort.PicturePath = PicturePathTB.Text;
            CurrentFlowerSort.ProductionTime = int.Parse(ProductionTimeTB.Text);
            CurrentFlowerSort.HalfLifeTime = Convert.ToInt32(HalfLifeTB.Text);
            CurrentFlowerSort.Size = int.Parse(SizeTB.Text); //text changed
            DialogResult = true;
            ClearAll();
        }

        private void Regret_Click(object sender, RoutedEventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            NameTB.Clear();
            PicturePathTB.Clear();
            ProductionTimeTB.Clear();
            HalfLifeTB.Clear();
            SizeTB.Clear();
        }

        

    }
}
