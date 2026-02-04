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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int cislo;
        public Random r;
        public bool koniechry;
        public int pocetPokusov;
        public const int maxPocetPokusov = 10;
        public int poslednavzdialenost;
        public MainWindow()
        {
            InitializeComponent();
            r = new Random();
            cislo = r.Next(1, 101);
            koniechry = false;
            pocetPokusov = 0;
            poslednavzdialenost = 0;
            Cheat.Text = cislo.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pocetPokusov++;
            if (koniechry) return;
            string text = Zadanie.Text;
            int zadanieCislo = int.Parse(text);
            int aktualnavzdialenost = Math.Abs(cislo - zadanieCislo);
            Zadanie.Clear();
            Pokusy.Text = pocetPokusov.ToString();
            
            if (zadanieCislo == cislo)
            {
                koniechry = true;
                Info.Text = "Uhadol si";
            }
            else
            {
                if (pocetPokusov == maxPocetPokusov)
                {
                    koniechry = true;
                    Info.Text = "Koniec hry. Cislo bolo "+ cislo;
                    return;
                }
                if (pocetPokusov == 0)
                {
                    if (zadanieCislo > 0)
                    {
                        Info.Text = "Nizsie";
                        
                        

                    }
                    if (zadanieCislo < 0)
                    {
                        Info.Text = "Vyssie";
                        



                    }
                    poslednavzdialenost = aktualnavzdialenost;
                    return;
                }
                if (aktualnavzdialenost > poslednavzdialenost)
                {
                    Info.Text = "Chladnejsie";
                }

                if (aktualnavzdialenost < poslednavzdialenost) 
                {
                    Info.Text = "Teplejsie";
                }
                if (aktualnavzdialenost == poslednavzdialenost)
                {
                    Info.Text = "Rovnako";
                }

               
}
            }
            
        
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          
        }

        private void Zadanie_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}