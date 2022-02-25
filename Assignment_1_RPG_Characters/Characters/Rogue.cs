using Assignment_1_RPG_Characters.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_RPG_Characters.Characters
{
    public class Rogue : Character
    {
        public Rogue()
        {
            BasePrimaryAttributes = new PrimaryAttributes()
            {
                Strength = 2,
                Dexterity = 6,
                Intelligence = 1
            };

            LevelUpPrimaryAttributes = new PrimaryAttributes()
            {
                Strength = 1,
                Dexterity = 4,
                Intelligence = 1
            };

            TotalPrimaryAttributes = new PrimaryAttributes(BasePrimaryAttributes);

            Damage = calculateDamage();
        }

        public override double calculateDamage()
        {
            double attributeDamage = TotalPrimaryAttributes.Dexterity;
            return base.calculateDamage() * (1 + attributeDamage / 100);
        }

        public override bool canEquip(Weapon weapon)
        {
            return weapon.WeaponType == WeaponType.Dagger || weapon.WeaponType == WeaponType.Sword;
        }
        public override bool canEquip(Armor armor)
        {
            return armor.ArmorType == ArmorType.Leather || armor.ArmorType == ArmorType.Mail;
        }
    }
}
