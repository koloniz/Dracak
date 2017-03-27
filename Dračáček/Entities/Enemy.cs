using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dračáček
{
    class Enemy : Base_atr
    {
        public Enemy(string type) {
            switch (type) {
                case "bog_monster":
                    name = "Příšera z bažin";
                    hp = 1000;
                    strenght = 200;
                    break;
                case "var_atra_fighter":
                    break;
                case "kaer_trolde_fighter":
                    break;
                case "harpy":
                    break;
                case "gryf":
                    break;
                case "water_hag":
                    break;
                case "crabby_staby":
                    break;

                case "":
                    break;
            }
        }
    }
}
