using Assignment_1_RPG_Characters.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_RPG_Characters.Items
{
    public abstract class Item
    {
        public string Name { get; set; } = "";
        public int RequiredLevel { get; set; } = 1;
        public Slot EquipSlot { get; set; }
        public PrimaryAttributes Attributes { get; set; } = new PrimaryAttributes();
    }
}
