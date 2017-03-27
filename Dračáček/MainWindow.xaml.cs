using Dračáček.Entities;
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
using System.IO;


namespace Dračáček
{
    public partial class MainWindow : Window
    {
        string type;
        string name;
        string enemy_choose;

        bool enemyIsCreated;

        Enemy _enemy;
        Player Avatar;
        Main story_main = new Main();
        Doren story_doren = new Doren();
        Var_atra story_var_atra = new Var_atra();
        Kaer_trolde story_kaer_trolde = new Kaer_trolde();
        Black_reach_island story_black_reach_island = new Black_reach_island();

        public MainWindow()
        {
            InitializeComponent();
        }
        public void GoToStart(object sender, RoutedEventArgs e)
        {
            Character_choice.IsSelected = true;
        }
        public void Choose_warrior(object sender, RoutedEventArgs e)
        {
            type = "Warrior";
            Name_choice.IsSelected = true;
        }
        public void Choose_sorcerer(object sender, RoutedEventArgs e)
        {
            type = "Sorcerer";
            Name_choice.IsSelected = true;
        }
        public void Choose_archer(object sender, RoutedEventArgs e)
        {
            type = "Archer";
            Name_choice.IsSelected = true;
        }
        public void Start_new_game(object sender, RoutedEventArgs e)
        {
            Story.IsSelected = true;
            Player Avatar = new Player(name, type);
            ReturnStory("start");
        }
        public void GoToFight(object sender, RoutedEventArgs e) {
            Area_Fight.IsSelected = true;
            switch (attack_place.Text)
            {
                case "Doren":
                    enemy_choose = "bog_monster";
                    break;
                case "Kaer_Trolde":
                    enemy_choose = "kaer_trolde_fighter";
                    break;
                case "Var_Atra":
                    enemy_choose = "var_atra_fighter";
                    break;
            }
            Fight(enemy_choose,0,0);
        }
        public void GoToMap(object sender, RoutedEventArgs e)
        {
            Map.IsSelected = true;
        }
        public void GoToDoren(object sender, RoutedEventArgs e)
        {
            Area_Doren.IsSelected = true;
            attack_place.Text = "Doren";
        }
        public void GoToKaerTrolde(object sender, RoutedEventArgs e)
        {
            Area_Kaer_trolde.IsSelected = true;
            attack_place.Text = "Kaer_Trolde";
        }
        public void GoToVarAtra(object sender, RoutedEventArgs e)
        {
            Area_Var_atra.IsSelected = true;
            attack_place.Text = "Var_Atra";
        }
        public void GoToBlackReachIsland(object sender, RoutedEventArgs e)
        {
            Area_Black_reach_island.IsSelected = true;
            attack_place.Text = "Black_Reach_Island";
        }
        public void Menu(object sender, SelectionChangedEventArgs e)
        {
        }
        public void CreateEnemy(string enemy_choose) {
            _enemy = new Enemy(enemy_choose);
        }
        public void playerAttack(int player_attack_type)
        {

        }
        public void enemyAttack(int enemy_attack_type)
        {

        }
        public void Loot() {

        }
        public void CheckState()
        {
            if (_enemy.hp <= 0) {
                switch (attack_place.Text) {
                    case "Doren":
                        Area_Doren.IsSelected = true;
                        break;
                    case "Kaer_Trolde":
                        Area_Kaer_trolde.IsSelected = true;
                        break;
                    case "Var_Atra":
                        Area_Var_atra.IsSelected = true;
                        break;
                    case "Black_Reach_Island":
                        Area_Black_reach_island.IsSelected = true;
                        break;
                }
                Loot();
            }
            else if (Avatar.hp <= 0) {

            }
        }
        public void Fight(string _enemy_choose, int player_attack_type, int enemy_attack_type)
        {
            if (enemyIsCreated == false)
            {
                CreateEnemy(_enemy_choose);
                enemyIsCreated = true;
            }
            else {
                playerAttack(player_attack_type);
                enemyAttack(enemy_attack_type);
                CheckState();
            }
            
        }
        public void ReturnStory(string story_part) {
            switch (story_part) {
                case "start":
                    test_message.Text = story_main.StoryItem[0] + Environment.NewLine + story_main.StoryItem[1];
                    break;
                case "boss":
                    test_message.Text = story_main.StoryItem[2] + Environment.NewLine + "Odemčen boj s drakem (final boss)";
                    break;
                case "end":
                    test_message.Text = story_main.StoryItem[3];
                    break;
                case "death":
                    test_message.Text = "Git Gut(zemřel jsi)";
                    break;
                case "":
                    break;

            }
        }
    }
}
//Player Avatar = new Player();