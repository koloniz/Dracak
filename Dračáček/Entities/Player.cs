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
            hp = 2000;
            strenght = 250;
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
            int lvl = 1;
        }
        public override string ToString()
        {
            return hp + " " + strenght + " " + spec_ability + " " + name;
        }

    }
}
