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
        int player_damage;
        int enemy_damage;
        bool enemy_dodge;

        static Random rnd0 = new Random();
        int ifDodge = rnd0.Next(1, 10);

        static Random rnd1 = new Random();
        int dragonAttack = rnd1.Next(1, 20);

        bool enemyIsCreated;
        bool dodge_heal;

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
        public void ReturnStory(string story_part)
        {
            switch (story_part)
            {
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
        public void GenerateButtons(string _type)
        {
            switch (_type)
            {
                case "spell":
                    strong_attack.Content = "Spell";
                    weak_attack.Content = "Meč";
                    heal.Content = "Heal Spell";
                    break;
                case "sword":
                    strong_attack.Content = "Meč";
                    weak_attack.Content = "Luk";
                    heal.Content = "Uhnutí";
                    break;
                case "bow":
                    strong_attack.Content = "Luk";
                    weak_attack.Content = "Dýka";
                    heal.Content = "Heal Salve";
                    break;
            }
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
            name = nick_text.Text;
            player_name.Text = name;
            Story.IsSelected = true;
            Player Avatar = new Player(name, type);
            GenerateButtons(Avatar.spec_ability);
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
            Fight(enemy_choose,0);
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
        public void strongAttack()
        {
            Fight("Blank",1);
        }
        public void weakAttack()
        {
            Fight("Blank", 2);
        }
        public void dodgeHeal()
        {
            Fight("Blank", 3);
        }
        public void playerAttack(int _player_attack_type)
        {
            switch (_player_attack_type) {
                case 1:
                    player_damage = 2 * Avatar.strenght;
                    break;
                case 2:

                    player_damage = 1 * Avatar.strenght;
                    break;
                case 3:
                    player_damage = 0;
                    dodge_heal = true;
                    break;
            }
        }
        public void enemyAttack()
        {
            switch (_enemy.lvl) {
                case 1:
                    enemy_damage = _enemy.strenght;
                    break;
                case 2:
                    switch (ifDodge) {
                        case 5:
                            enemy_damage = 0;
                            enemy_dodge = true;
                            break;
                        case default(int):
                            enemy_damage = _enemy.strenght;
                            break;
                    }
                    break;
                case 3:
                    switch (dragonAttack)
                    {
                        case 5:
                            enemy_damage = 0;
                            enemy_dodge = true;
                            break;
                        case 6:
                            enemy_damage = 0;
                            enemy_dodge = true;
                            break;
                        case 25:
                            enemy_damage = 0;
                            enemy_dodge = true;
                            break;
                        case 10:
                            enemy_damage = 2 * _enemy.strenght;
                            break;
                        case default(int):
                            enemy_damage = _enemy.strenght;
                            break;
                    }
                    break;
            }
        }
        public void Announce(bool _start) {
            player_stats.Text = "Zdraví: " + Avatar.hp + Environment.NewLine + "Výdrž: " + Avatar.ep + Environment.NewLine + "Síla: " + Avatar.strenght + Environment.NewLine + "Level: " + Avatar.lvl + Environment.NewLine;
            enemy_status.Text = "Zdraví: " + _enemy.hp + Environment.NewLine + "Výdrž: " + _enemy.ep + Environment.NewLine + "Síla: " + _enemy.strenght + Environment.NewLine + "Level: " + _enemy.lvl + Environment.NewLine;
            enemy_name.Text = _enemy.name;
            if (_start == true){
                fight_announcer.Text = "Boj začíná! Zvol útok!";
            }
            else {

            }
        }
        public void ClearFightAnnoucer()
        {
            fight_announcer.Text = ""; 
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
                Avatar.PlayerEternalHeal(Avatar.lvl);
            }
            else if (Avatar.hp <= 0) {
                Story.IsSelected = true;
                ReturnStory("death");
                story_continue_button.Visibility = Visibility.Hidden;
            }
        }
        public void Fight(string _enemy_choose, int player_attack_type)
        {
            if (enemyIsCreated == false)
            {
                CreateEnemy(_enemy_choose);
                ClearFightAnnoucer();
                enemyIsCreated = true;
                Announce(true);
            }
            else {
                playerAttack(player_attack_type);
                enemyAttack();
                CheckState();
                Announce(false);
            }
            
        }
    }
}
//Player Avatar = new Player();