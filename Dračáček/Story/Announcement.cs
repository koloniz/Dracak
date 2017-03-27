using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dračáček
{
    class Announcement : Story
    {
        public Announcement() {
            StoryItem.Add("Dostáváš následující loot:");
        }
    }
}
