using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dračáček
{
    abstract class Base_atr
    {
        public string name { get; set; }
        public int hp { get; set; }
        public int ep { get; set; }
        public int lvl { get; set; }
        public int strenght { get; set; }
        public string spec_ability { get; set; }
    }
}
