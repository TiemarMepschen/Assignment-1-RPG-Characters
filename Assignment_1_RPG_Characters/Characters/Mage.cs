using Assignment_1_RPG_Characters.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_RPG_Characters.Characters
{
    public class Mage : Character
    {
        public Mage()
        {
            BasePrimaryAttributes = new PrimaryAttributes()
            {
                Strength = 1,
                Dexterity = 1,
                Intelligence = 8
            };

            LevelUpPrimaryAttributes = new PrimaryAttributes()
            {
                Strength = 1,
                Dexterity = 1,
                Intelligence = 5
            };

            TotalPrimaryAttributes = new PrimaryAttributes(BasePrimaryAttributes);

            Damage = calculateDamage();
        }

        public override double calculateDamage()
        {
            double attributeDamage = TotalPrimaryAttributes.Intelligence;
            return base.calculateDamage() * (1 + attributeDamage/100);
        }

        public override bool canEquip(Weapon weapon)
        {
            return weapon.WeaponType == WeaponType.Staff || weapon.WeaponType == WeaponType.Wand;
        }
        public override bool canEquip(Armor armor)
        {
            return armor.ArmorType == ArmorType.Cloth;
        }
    }
}
