using Assignment_1_RPG_Characters.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_RPG_Characters.Characters
{
    public class Warrior : Character
    {
        public Warrior()
        {
            BasePrimaryAttributes = new PrimaryAttributes()
            {
                Strength = 5,
                Dexterity = 2,
                Intelligence = 1
            };

            LevelUpPrimaryAttributes = new PrimaryAttributes()
            {
                Strength = 3,
                Dexterity = 2,
                Intelligence = 1
            };

            TotalPrimaryAttributes = new PrimaryAttributes(BasePrimaryAttributes);

            Damage = calculateDamage();
        }

        public override double calculateDamage()
        {
            double attributeDamage = TotalPrimaryAttributes.Strength;
            return base.calculateDamage() * (1 + attributeDamage / 100);
        }
        public override bool canEquip(Weapon weapon)
        {
            return weapon.WeaponType == WeaponType.Axe || weapon.WeaponType == WeaponType.Hammer || weapon.WeaponType == WeaponType.Sword;
        }
        public override bool canEquip(Armor armor)
        {
            return armor.ArmorType == ArmorType.Mail || armor.ArmorType == ArmorType.Plate;
        }
    }
}
