using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dračáček.Entities
{
    class Player : Base_atr
    {
        public Player(string Name, string Type)
        {
            hp = 1000;
            ep = 100;
            strenght = 50;
            int lvl = 1;
            switch (Type)
            {
                case "Sorcerer":
                    spec_ability = "spell";
                    break;

                case "Warrior":
                    spec_ability = "sword";
                    break;

                case "Archer":
                    spec_ability = "bow";
                    break;
            }
            name = Name;
            
        }

        public void PlayerLevelUp(int level)
        {
            switch (level) {
                case 1:
                    hp = 2000;
                    ep = 200;
                    strenght = 50;
                    lvl = 2;
                    break;
                case 2:
                    hp = 3000;
                    ep = 300;
                    strenght = 50;
                    lvl = 3;
                    break;
                case 3:
                    hp = 4000;
                    ep = 400;
                    strenght = 50;
                    lvl = 4;
                    break;
                case 4:
                    hp = 5000;
                    ep = 500;
                    strenght = 50;
                    lvl = 5;
                    break;

            }
        }

        public override string ToString()
        {
            return hp + " " + strenght + " " + spec_ability + " " + name;
        }

    }
}
