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

namespace Controls
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
        public int CountButton { get; set; } = 0;
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            ++CountButton;
            //btn.Content = CountButton.ToString();
        }
        public int CountButtonRepeat { get; set; } = 0;
        private void btn_repeat_Click(object sender, RoutedEventArgs e)
        {
            CountButtonRepeat++;

           // btn_repeat.Content = CountButtonRepeat.ToString();
        }
        public int CountToggleButton { get; set; } = 0;
        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {

            CountToggleButton++;
        //    btn_toggle.Content = CountToggleButton.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          //  myframe.Source = new Uri($"https://www.google.com/search?q={searchTxtb.Text}");
        }
    }
}
