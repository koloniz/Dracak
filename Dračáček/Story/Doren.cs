using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dračáček
{
    class Doren : Story
    {
        public Doren()
        {
            StoryItem.Add("Jsi v Dorenu. Jsou tu jen bažiny, husté lesy, a poněkud vražedná fauna. Skus se podívat kolem, může tu být kus brnění.");
            StoryItem.Add("Zabil jsi monstrum. Kus brnění jsi ale nenašel, skus koukat dál.");
            StoryItem.Add("Našel jsi zohavené monstrum, které bude mnohem těžší zkolit. Možná má ale u sebe něco ceného!");
            StoryItem.Add("Ze zabitého monstra vypadnul kus brnění! Zkus teď navštívit některou z jiných oblastí a najdi ostatní kusy!");
            StoryItem.Add("");
        }
    }
}
