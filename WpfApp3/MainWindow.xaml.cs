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
using Cvicenie_Armor;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string imagePath { get; set; } = "C:\\Users\\khanchenkod25\\Source\\Repos\\csharp\\WpfApp3\\images\\minecraft_armour_sheet_by_dragonshadow3_d8ebr67-414w-2x.webp";

        public List<armorFart> ArmorPart_Head { get; set; } = new List<armorFart>();
        public List<armorFart> ArmorPart_Body { get; set; } = new List<armorFart>();
        public List<armorFart> ArmorPart_Pant { get; set; } = new List<armorFart>();
        public List<armorFart> ArmorPart_Leg { get; set; } = new List<armorFart>();

        public armorFart Head { get; set; }
        public armorFart Body { get; set; }
        public armorFart Pant { get; set; }
        public armorFart Leg { get; set; }


        public MainWindow()
        {
            InitializeComponent();

            List<armorFart> Armors_helm = new List<armorFart>();

            Armors_helm.Add(new armorFart("Plesinka", 0, EArmorPartName.Helmet, EArmorType.None , 28, 29, 100, 90));
            Armors_helm.Add(new armorFart("Helma bronzova", 1, EArmorPartName.Helmet, EArmorType.Bronze,  28, 29, 100, 90));
            Armors_helm.Add(new armorFart("Helma retiazkova", 2, EArmorPartName.Helmet, EArmorType.Chain, 177, 29, 100, 90));
            Armors_helm.Add(new armorFart("Helma zelezna", 5, EArmorPartName.Helmet, EArmorType.Iron, 338, 29, 100, 90));
            Armors_helm.Add(new armorFart("Helma zlata", 10, EArmorPartName.Helmet, EArmorType.Gold, 505, 29, 100, 90));
            Armors_helm.Add(new armorFart("Helma diamantova", 20, EArmorPartName.Helmet, EArmorType.Diamond, 659, 29, 100, 90));

            ComboBox_helmetPicker.ItemsSource = Armors_helm;


            List<armorFart> Armors_body = new List<armorFart>();

            Armors_body.Add(new armorFart("Hola hrud", 0, EArmorPartName.Body, EArmorType.None, 0, 0, 0, 0));
            Armors_body.Add(new armorFart("Body bronzove", 5, EArmorPartName.Body, EArmorType.Bronze,  7, 136, 139, 130));
            Armors_body.Add(new armorFart("Body retiazkove", 10, EArmorPartName.Body, EArmorType.Chain, 159, 136, 139, 130));
            Armors_body.Add(new armorFart("Body zelezne", 15, EArmorPartName.Body, EArmorType.Iron, 321, 136, 139, 130));
            Armors_body.Add(new armorFart("Body zlate", 30, EArmorPartName.Body, EArmorType.Gold, 486, 136, 139, 130));
            Armors_body.Add(new armorFart("Body diamantove", 50, EArmorPartName.Body, EArmorType.Diamond, 639, 136, 139, 130));
            ComboBox_bodyPicker.ItemsSource = Armors_body;

            List<armorFart> Armors_Pants = new List<armorFart>();

            Armors_Pants.Add(new armorFart("Trenky", 0, EArmorPartName.Pant, EArmorType.None, 0, 0, 0, 0));
            Armors_Pants.Add(new armorFart("Nohavice bronzove", 2, EArmorPartName.Pant, EArmorType.Bronze, 26, 279, 100, 131));
            Armors_Pants.Add(new armorFart("Nohavice retiazkove", 4, EArmorPartName.Pant, EArmorType.Chain, 179, 279, 100, 131));
            Armors_Pants.Add(new armorFart("Nohavice zelezne", 8, EArmorPartName.Pant, EArmorType.Iron, 339, 279, 100, 131));
            Armors_Pants.Add(new armorFart("Nohavice zlate", 15, EArmorPartName.Pant, EArmorType.Gold, 506, 279, 100, 131));
            Armors_Pants.Add(new armorFart("Nohavice diamantove", 22, EArmorPartName.Pant, EArmorType.Diamond, 657, 279, 100, 131));
            Combox_PantsPicker.ItemsSource = Armors_Pants;

            List<armorFart> Armors_Leg = new List<armorFart>();

            Armors_Leg.Add(new armorFart("Sandale", 0, EArmorPartName.Leg, EArmorType.None, 0, 0, 0, 0));
            Armors_Leg.Add(new armorFart("Topanky bronzove", 2, EArmorPartName.Leg, EArmorType.Bronze,  2, 425, 140, 100));
            Armors_Leg.Add(new armorFart("Topanky retiazkove", 4, EArmorPartName.Leg, EArmorType.Chain,  159, 425, 140, 100));
            Armors_Leg.Add(new armorFart("Topanky zelezne", 8, EArmorPartName.Leg, EArmorType.Iron, 319, 425, 140, 100));
            Armors_Leg.Add(new armorFart("Topanky zlate", 15, EArmorPartName.Leg, EArmorType.Gold, 484, 425, 140, 100));
            Armors_Leg.Add(new armorFart("Topanky diamantove", 22, EArmorPartName.Leg, EArmorType.Diamond, 636, 425, 140, 100));
            Combox_LegPicker.ItemsSource = Armors_Leg;





        }

        private void ComboBox_helmetPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            armorFart armorPart = (armorFart)ComboBox_helmetPicker.SelectedItem as armorFart;

            if (armorPart.ArmorType != EArmorType.None)
            {
                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(imagePath, UriKind.Absolute);
                bitmap.CacheOption = BitmapCacheOption.OnLoad; // aby sa súbor neu lockol
                bitmap.EndInit();
                bitmap.Freeze();

                var cropped = new CroppedBitmap(bitmap, new Int32Rect(armorPart.XLeft, armorPart.YTop, armorPart.Height, armorPart.Width));
                cropped.Freeze();

                Image_HelmetPlaceHolder.Source = cropped;
                Image_HelmetPlaceHolder.Visibility = Visibility.Visible;
            }
            else
            {
                Image_HelmetPlaceHolder.Visibility = Visibility.Hidden;
            }
        


            UpdateLabels();
        }

        private void ComboBox_bodyPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            armorFart armorPart = (armorFart)ComboBox_bodyPicker.SelectedItem as armorFart;

            if (armorPart.ArmorType != EArmorType.None)
            {
                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(imagePath, UriKind.Absolute);
                bitmap.CacheOption = BitmapCacheOption.OnLoad; // aby sa súbor neu lockol
                bitmap.EndInit();
                bitmap.Freeze();

                var cropped = new CroppedBitmap(bitmap, new Int32Rect(armorPart.XLeft, armorPart.YTop, armorPart.Height, armorPart.Width));
                cropped.Freeze();

                Image_BodyPlaceHolder.Source = cropped;
                Image_BodyPlaceHolder.Visibility = Visibility.Visible;
            }
            else
            {
                Image_BodyPlaceHolder.Visibility = Visibility.Hidden;
            }



            UpdateLabels();

        }

        private void Combox_PantsPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            armorFart armorPart = (armorFart)Combox_PantsPicker.SelectedItem as armorFart;

            if (armorPart.ArmorType != EArmorType.None)
            {
                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(imagePath, UriKind.Absolute);
                bitmap.CacheOption = BitmapCacheOption.OnLoad; // aby sa súbor neu lockol
                bitmap.EndInit();
                bitmap.Freeze();

                var cropped = new CroppedBitmap(bitmap, new Int32Rect(armorPart.XLeft, armorPart.YTop, armorPart.Height, armorPart.Width));
                cropped.Freeze();

                Image_PantsPlaceHolder.Source = cropped;
                Image_PantsPlaceHolder.Visibility = Visibility.Visible;
            }
            else
            {
                Image_PantsPlaceHolder.Visibility = Visibility.Hidden;
            }



            UpdateLabels();

        }

        private void Combox_LegPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            armorFart armorPart = (armorFart)Combox_LegPicker.SelectedItem as armorFart;

            if (armorPart.ArmorType != EArmorType.None)
            {
                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(imagePath, UriKind.Absolute);
                bitmap.CacheOption = BitmapCacheOption.OnLoad; // aby sa súbor neu lockol
                bitmap.EndInit();
                bitmap.Freeze();

                var cropped = new CroppedBitmap(bitmap, new Int32Rect(armorPart.XLeft, armorPart.YTop, armorPart.Width, armorPart.Height));
                cropped.Freeze();

                Image_LegPlaceHolder.Source = cropped;
                Image_LegPlaceHolder.Visibility = Visibility.Visible;
            }
            else
            {
                Image_LegPlaceHolder.Visibility = Visibility.Hidden;
            }


            UpdateLabels();
            
        }
        
        private void UpdateLabels()
        {
            var playerSet = new List<armorFart>();

            if (Head != null)
                playerSet.Add(Head);
            if (Body != null)
                playerSet.Add(Body);
            if (Pant != null)
                playerSet.Add(Pant);
            if (Leg != null)
                playerSet.Add(Leg);



            var groupedItems = playerSet.GroupBy(p => p.ArmorType, (key, g) => new { ArmorType = key, Items = g.ToList() }).ToList();
            var multiplaierValue = groupedItems.OrderByDescending(x => x.Items.Count).First().Items.Count;
            Label_ArmorMultiplier.Content = multiplaierValue;

            var numberOfArmor = playerSet.Sum(x => x.ArmorPower);
            Label_ActualArmor.Content = $"{numberOfArmor} (+{multiplaierValue * numberOfArmor})";
        }
    }
}