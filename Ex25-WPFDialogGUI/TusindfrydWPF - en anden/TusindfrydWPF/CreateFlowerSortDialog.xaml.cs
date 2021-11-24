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
using System.Windows.Shapes;

namespace TusindfrydWPF
{
    /// <summary>
    /// Interaction logic for CreateFlowerSortDialog.xaml
    /// </summary>
    public partial class CreateFlowerSortDialog : Window
    {
        public FlowerSort CurrentFlowerSort;

        public CreateFlowerSortDialog()
        {
            InitializeComponent();
            CurrentFlowerSort = new FlowerSort();
        }

        //TextBox
        private void NameTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void FilePathTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            CurrentFlowerSort.FilePath = FilePathTB.Text;
        }
        private void FilePathTB_LostFocus(object sender, RoutedEventArgs e) // LOST FOCUS
        {
            Uri uri = new Uri(FilePathTB.Text, UriKind.Absolute); // C:\Users\Emil\source\repos\TusindfrydWPF\TusindfrydWPF\bin\Debug\net5.0-windows\hund.jpg
            FlowerSortImage.Source = new BitmapImage(uri);
        }

        private void ProductionTimeTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void HalfLifeTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SizeTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        //Button
        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            CurrentFlowerSort.Name = NameTB.Text;
            CurrentFlowerSort.FilePath = FilePathTB.Text;
            CurrentFlowerSort.ProductionTime = int.Parse(ProductionTimeTB.Text);
            CurrentFlowerSort.HalfLifeTime = int.Parse(HalfLifeTB.Text);
            CurrentFlowerSort.Size = int.Parse(SizeTB.Text);
            this.DialogResult = true;
            ClearAll();
        }

        private void RegretBtn_Click(object sender, RoutedEventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            NameTB.Clear();
            FilePathTB.Clear();
            ProductionTimeTB.Clear();
            HalfLifeTB.Clear();
            SizeTB.Clear();
        }

        

    }
}
