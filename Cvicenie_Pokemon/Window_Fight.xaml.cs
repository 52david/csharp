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

namespace Cvicenie_Pokemon
{
    /// <summary>
    /// Interaction logic for Window_Fight.xaml
    /// </summary>
    public partial class Window_Fight : Window
    {
        public Hero myActualHero { get; set; }
        public Enemy Enemy { get; set; }
        public Window_Fight(Hero hero, Enemy enemy)
        {
            InitializeComponent();

            myActualHero = hero;
            Enemy = enemy;

            ProgressBar_Hero.Value = hero.Health;
            ProgressBar_Hero.Maximum = hero.Health_Max;

            ProgressBar_Enemy.Value = enemy.Health_Max;
            ProgressBar_Enemy.Maximum = enemy.Health_Max;

            ProgressBar_Energy.Value = hero.Energia;
            ProgressBar_Energy.Maximum = hero.Energia;

        }

        private void LightAttack_Click(object sender, RoutedEventArgs e)
        {

            HeroAttack(1); 

            MonsterAttack();

            ChecHP();

            
        }
        private void HeroAttack(int damageScale)
        {
            Enemy.Health_Max -= myActualHero.Damage = damageScale;

            ProgressBar_Enemy.Value = Enemy.Health_Max;


            
        }
        private void MonsterAttack()
        {
            myActualHero.Health -= Enemy.Damage;
            ProgressBar_Hero.Value = myActualHero.Health;
        }

        private void MediumAttack_Click(object sender, RoutedEventArgs e)
        {
            HeroAttack(2);
            MonsterAttack();
            ChecHP();
        }

        private void HardAttack_Copy1_Click(object sender, RoutedEventArgs e)
        {
            HeroAttack(3);
            MonsterAttack();
            ChecHP();
        }
        private void ChecHP()
        {
            if (myActualHero.Health <= 0)
            {
                Label_GameStatus.Content = "Looser";
            }
            if (Enemy.Health_Max <= 0)
            {
                Label_GameStatus.Content = "Winner";
            }


        }
      
    }    
}
    

