using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_RPG_Characters.Items
{
    public class Weapon : Item
    {
        public Weapon()
        {
            EquipSlot = Slot.Weapon;
        }
        public WeaponType WeaponType { get; set; }
        public WeaponAttributes WeaponAttributes { get; set; } = new WeaponAttributes();
    }
}
