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

namespace Cvicenie_Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Hero myHero = new Hero(50, 100 ,10, 100);
            Enemy myEnemy = new Enemy(200 ,1);

            

            Window_Fight fight_window = new Window_Fight(myHero,myEnemy);
            fight_window.Show();

            /*fight_window.ProgressBar_Hero.Value = myHero.Health;
            fight_window.ProgressBar_Enemy.Value = myEnemy.Health_Max;*/
        }
        /*
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            string myTextBoxValue = TextBox_MyValue.Text;

            Window_Fight window = new Window_Fight(myTextBoxValue);
            window.Show();*/

    }
}
