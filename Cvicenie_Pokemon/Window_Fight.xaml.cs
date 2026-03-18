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

            HeroAttack(1, 5, 95, 10);

            MonsterAttack();
            RegenerateEnergy();
            UpdateHealthColors();
            ChecHP();
            UpdateHPLabels();


        }
        private void HeroAttack(int damageScale, int energyCost, int hitChance, int critChance)
        {
            if (myActualHero.Energia < energyCost)
            {
                Label_GameStatus.Content = "Not enough energy!";
                return;
            }

            myActualHero.Energia -= energyCost;


            bool isHit = r.Next(0, 100) < hitChance;

            if (!isHit)
            {
                Label_GameStatus.Content = "Missed!";
                ProgressBar_Energy.Value = myActualHero.Energia;
                return;
            }

            int damage = damageScale * myActualHero.Damage;


            bool isCritical = r.Next(0, 100) < critChance;

            if (isCritical)
            {
                damage *= 2;
                Label_GameStatus.Content = "CRITICAL HIT!";
            }
            else
            {
                Label_GameStatus.Content = "Hit!";
            }

            Enemy.Health_Max -= damage;

            ProgressBar_Enemy.Value = Enemy.Health_Max;
            ProgressBar_Energy.Value = myActualHero.Energia;
        }
        private void MonsterAttack()
        {
            bool isHit = r.Next(0, 100) < 85;

            if (!isHit)
            {
                Label_GameStatus.Content = "Enemy missed!";
                return;
            }

            myActualHero.Health -= Enemy.Damage;
            ProgressBar_Hero.Value = myActualHero.Health;
            UpdateHealthColors();
        }

        private void MediumAttack_Click(object sender, RoutedEventArgs e)
        {
            HeroAttack(2, 10, 80, 15);
            MonsterAttack();
            RegenerateEnergy();
            ChecHP();
            UpdateHealthColors();
            UpdateHPLabels();
        }

        private void HardAttack_Copy1_Click(object sender, RoutedEventArgs e)
        {
            HeroAttack(3, 20, 67, 7);
            MonsterAttack();
            RegenerateEnergy();
            ChecHP();
            UpdateHealthColors();
            UpdateHPLabels();
            ReduceCooldowns();
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

        private void ProgressBar_Energy_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
        private void RegenerateEnergy()
        {
            myActualHero.Energia += 5;
            if (myActualHero.Energia > myActualHero.Energy_Max)
            {
                myActualHero.Energia = myActualHero.Energy_Max;
            }
            ProgressBar_Energy.Value = myActualHero.Energia;


        }

        private void Heal(int healAmount, int energyCost)
        {
            if (myActualHero.Energia < energyCost)
            {
                Label_GameStatus.Content = "Not enough energy to heal!";
                return;
            }

            myActualHero.Energia -= energyCost;

            myActualHero.Health += healAmount;

            if (myActualHero.Health > myActualHero.Health_Max)
                myActualHero.Health = myActualHero.Health_Max;

            ProgressBar_Hero.Value = myActualHero.Health;
            ProgressBar_Energy.Value = myActualHero.Energia;

            if (myActualHero.Health == myActualHero.Health_Max)
            {
                Label_GameStatus.Content = "HP is already full!";
                return;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Heal(20, 15);
            UpdateHPLabels();
            MonsterAttack();
            RegenerateEnergy();
            ChecHP();
            UpdateHealthColors();
        }
        private Random r = new Random();

        private void RestartFight()
        {
            
            myActualHero.Health = myActualHero.Health_Max;
            myActualHero.Energia = myActualHero.Energy_Max;

            
            Enemy.Health_Max = Enemy.Health_Max;

            
            ProgressBar_Hero.Value = myActualHero.Health;
            ProgressBar_Enemy.Value = Enemy.Health_Max;
            ProgressBar_Energy.Value = myActualHero.Energia;

            
            Label_GameStatus.Content = "";
        }

        private void Button_Restart_Click(object sender, RoutedEventArgs e)
        {
            RestartFight();
            UpdateHealthColors();
            UpdateHPLabels();
        }
        private void UpdateHealthColors()
        {
            double heroPercent = (double)myActualHero.Health / myActualHero.Health_Max;
            double enemyPercent = (double)Enemy.Health_Max / Enemy.Health_Max;

            
            if (heroPercent > 0.6)
                ProgressBar_Hero.Foreground = Brushes.Green;
            else if (heroPercent > 0.3)
                ProgressBar_Hero.Foreground = Brushes.Red;
            

            
            if (enemyPercent > 0.6)
                ProgressBar_Enemy.Foreground = Brushes.Green;
            else if (enemyPercent > 0.3)
                ProgressBar_Enemy.Foreground = Brushes.Red;
            
        }
        private void UpdateHPLabels()
        {
            Label_HeroHP.Content = $"{myActualHero.Health} / {myActualHero.Health_Max}";
            Label_EnemyHP.Content = $"{Enemy.Health_Max} / {Enemy.Health_Max}";
        }
        private int hardAttackCooldown = 0;
        private int hardAttackMaxCooldown = 3;

        private void HardAttack_Click(object sender, RoutedEventArgs e)
        {
            if (hardAttackCooldown > 0)
            {
                Label_GameStatus.Content = $"Skill on cooldown ({hardAttackCooldown})";
                return;
            }

            HeroAttack(3, 20, 60, 40); 

            hardAttackCooldown = hardAttackMaxCooldown;

            MonsterAttack();
            RegenerateEnergy();
            ReduceCooldowns();
            ChecHP();
        }
        private void ReduceCooldowns()
        {
            if (hardAttackCooldown > 0)
                hardAttackCooldown--;
        }

    }  
        
    }
    

