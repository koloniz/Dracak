using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dračáček
{
    class Main : Story
    {
        public Main() {
            StoryItem.Add("Dorazil jsi do Vergenu. Jsi zde kvůli té legendě. Pokud se ti podaří najít ono legendární brnění nekonečna, můžeš se utkat s Drakem.");
            StoryItem.Add("Začni s prozkoumáním okolních oblastí.");
            StoryItem.Add("Získal jsi všechny kusy brnění nekonečna. Nyní máš možnost utkat se s drakem. Mužeš ale jít i do už prozkoumaných oblastí a dál se zlepšovat!");
            StoryItem.Add("Porazil jsi draka, a získal jsi jeho sílu! Nyní je z tebe opravdový drakobijec. Se svou novou zbrojí teď můžeš dokázat mnoho, a tak se zase vydáváš na další adventůru.");
            StoryItem.Add("");
        }
    }
}
