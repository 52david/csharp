using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DateTime startTime;
        private DateTime stopTime;
        private TimeSpan elapsed;
        private bool runnig;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            startTime = DateTime.Now;

            Button_Click.IsEnabled = false;
            Button_Click_1.IsEnabled = true;

            Label.Content = "";
            TextBox.IsEnabled = false;
            Button_Click_2.IsEnabled = false;
            TextBox.Text = ""; 


            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            stopTime = DateTime.Now;

            elapsed = stopTime - startTime;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}