using Assignment_1_RPG_Characters.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_RPG_Characters.Characters
{
    public class Ranger : Character
    {
        public Ranger()
        {
            BasePrimaryAttributes = new PrimaryAttributes()
            {
                Strength = 1,
                Dexterity = 7,
                Intelligence = 1
            };

            LevelUpPrimaryAttributes = new PrimaryAttributes()
            {
                Strength = 1,
                Dexterity = 5,
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
            return weapon.WeaponType == WeaponType.Bow;
        }
        public override bool canEquip(Armor armor)
        {
            return armor.ArmorType == ArmorType.Leather || armor.ArmorType == ArmorType.Mail;
        }
    }
}
