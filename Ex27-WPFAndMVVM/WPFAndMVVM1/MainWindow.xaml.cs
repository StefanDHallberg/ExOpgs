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
using WPFAndMVVM1.ViewModels;

namespace WPFAndMVVM1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModels mvm = new MainViewModels();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = mvm; 
        }

        private void MySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //if (sliderBarText != null && MySlider.Value > 0d) 
            //    sliderBarText.Text = "Slider value is " + MySlider.Value.ToString();
            //Pga Slideren bliver loaded før text blokken - Så kun når Texten er klar til at run,
            //skal den kører methoden.
            //Method "MySlider_ValueChanged" bliver først kaldt når slideren bliver initialized i main-window 
        }

        //private void Update_to_DateTime_Click(object sender, RoutedEventArgs e)
        //{
        //    mvm.FirstName = DateTime.Now.ToString();
        //}
        private void Update_Label_Click(object sender, RoutedEventArgs e)
        {
            mvm.FirstName = DateTime.Now.ToString();
        }
    }
}
