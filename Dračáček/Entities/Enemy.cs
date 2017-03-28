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
                    hp = 600;
                    strenght = 80;
                    lvl = 1;
                    break;
                case "var_atra_fighter":
                    name = "Bojovník z Var Atra";
                    hp = 500;
                    strenght = 80;
                    lvl = 1;
                    break;
                case "kaer_trolde_fighter":
                    name = "Bojovník z Kaer Trolde";
                    hp = 700;
                    strenght = 80;
                    lvl = 1;
                    break;
                case "harpy":
                    name = "Harpyje";
                    hp = 1000;
                    strenght = 300;
                    ep = 100;
                    lvl = 2;
                    break;
                case "gryf":
                    name = "Gryf";
                    hp = 1000;
                    strenght = 300;
                    ep = 100;
                    lvl = 2;
                    break;
                case "water_hag":
                    name = "Ježibaba";
                    hp = 1000;
                    strenght = 300;
                    ep = 100;
                    lvl = 2;
                    break;
                case "crabby_staby":
                    name = "Přerostlý krab";
                    hp = 1000;
                    strenght = 300;
                    ep = 100;
                    lvl = 2;
                    break;
                case "dragon_boss":
                    name = "Bájný drak";
                    hp = 6000;
                    strenght = 500;
                    ep = 1000;
                    lvl = 5;
                    break;

                case "":
                    break;
            }
        }
    }
}
