using Assignment_1_RPG_Characters.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_RPG_Characters.Characters
{
    public abstract class Character
    {
        public string Name { get; set; } = "";
        public int Level { get; set; } = 1;
        public double Damage { get; set; } = 1;
        public PrimaryAttributes BasePrimaryAttributes { get; set; }
        public PrimaryAttributes TotalPrimaryAttributes { get; set; }
        public PrimaryAttributes LevelUpPrimaryAttributes { get; set; }
        public Dictionary<Slot, Item> Equipment { get; set; } = new Dictionary<Slot, Item>()
            {
                // Sets up all empty slots
                { Slot.Head, new Armor() },
                { Slot.Body, new Armor() },
                { Slot.Legs, new Armor() },
                { Slot.Weapon, new Weapon() },
            };

        /// <summary>
        /// Increases the characters level by 1, increases the total primary attributs by the level up primary attributes and recalculates damage.
        /// </summary>
        public void levelUp()
        {
            Level++;
            TotalPrimaryAttributes += LevelUpPrimaryAttributes;
            Damage = calculateDamage();
        }

        /// <summary>
        /// A method that, when overridden, calculates the current damage output of the character.
        /// </summary>
        /// <returns>A double representing the damage the character can deal.</returns>
        public virtual double calculateDamage()
        {
            Weapon weapon = (Weapon)Equipment[Slot.Weapon];
            double weaponDamage = weapon.WeaponAttributes.BaseDamage * weapon.WeaponAttributes.AttacksPerSecond;
            return weaponDamage;
        }

        /// <summary>
        /// A virtual method which, when overridden, checks whether the child class can equip the weapon.
        /// </summary>
        /// <param name="weapon">A weapon object to be checked.</param>
        /// <returns>A boolean representing whether the character can equip the armor in question.</returns>
        public virtual bool canEquip(Weapon weapon) { return true; }

        /// <summary>
        /// A virtual method which, when overridden, checks whether the child class can equip the armor.
        /// </summary>
        /// <param name="armor">An Armor object to be checked.</param>
        /// <returns>A boolean representing whether the character can equip the armor in question.</returns>
        public virtual bool canEquip(Armor armor) { return true; }

        /// <summary>
        /// A method that equips a weaopn in a partical slot.
        /// </summary>
        /// <param name="slot">The slot the weapon is going to be equipped in.</param>
        /// <param name="weapon">The Weapon object that the charcter wants to equip.</param>
        /// <returns>A string indicating success.</returns>
        /// <exception cref="InvalidWeaponException">An Exception that that indicates that the characters level is too low,
        /// the character type and weapon type do not match or the slot does not match the weapon slot</exception>
        public string equip(Slot slot, Weapon weapon)
        {
            if (Level >= weapon.RequiredLevel)
            {
                if (canEquip(weapon))
                {
                    if (slot == Slot.Weapon && weapon.EquipSlot == Slot.Weapon)
                    {
                        Equipment[slot] = weapon;
                        Damage = calculateDamage();
                        return "New weapon equipped!";
                    } else
                    {
                        throw new InvalidWeaponException("That weapon doesn't go in that slot!");
                    }
                } else
                {
                    throw new InvalidWeaponException($"A {this.GetType().Name} can't equip a(n) {weapon.WeaponType}!");
                }
            } else
            {
                throw new InvalidWeaponException("Your level is too low for this weapon!");
            }
        }

        public string equip(Weapon weapon)
        {
            return equip(weapon.EquipSlot, weapon);
        }

        /// <summary>
        /// A method that equips armor in a particular slot.
        /// </summary>
        /// <param name="slot">The slot the armor object is going to be equipped in.</param>
        /// <param name="armor">The Armor object that the charcter wants to equip.</param>
        /// <returns>A string indication success.</returns>
        /// <exception cref="InvalidArmorException">An Exception that that indicates that the characters level is too low,
        /// the character type and armor type do not match or the slot does not match the armor slot</exception>
        public string equip(Slot slot, Armor armor)
        {
            if (Level >= armor.RequiredLevel)
            {
                if (canEquip(armor))
                {
                    if (slot != Slot.Weapon && slot == armor.EquipSlot)
                    {
                        TotalPrimaryAttributes -= Equipment[slot].Attributes;
                        Equipment[slot] = armor;
                        TotalPrimaryAttributes += armor.Attributes;
                        return "New armor equipped!";
                    } else
                    {
                        throw new InvalidArmorException("That item doesn't go in that slot!");
                    }
                }
                else
                {
                    throw new InvalidArmorException($"A {this.GetType().Name} can't equip a(n) {armor.ArmorType}!");
                }
            }
            else
            {
                throw new InvalidArmorException("Your level is too low for this armor!");
            }
        }

        public string equip(Armor armor)
        {
            return equip(armor.EquipSlot, armor);
        }

        /// <summary>
        /// Removes the item that is currently in the particular slot.
        /// </summary>
        /// <param name="slot">The slot that will be emptied.</param>
        /// <returns>A string indicating success.</returns>
        public string unequip(Slot slot)
        {
            if (slot == Slot.Weapon)
            {
                Equipment[slot] = new Weapon();
                return "Weapon succesfully unequipped!";
            } else
            {
                Equipment[slot] = new Armor();
                return "Armor successfully unequipped!";
            }
        }

        /// <summary>
        /// Displays the characters class, name, attributes and equipment to the console.
        /// </summary>
        public void display()
        {
            StringBuilder sb = new StringBuilder(15);

            // Sets the number of spaces so all the information fits
            int maxSizeLeft = 15;
            int maxSizeRight = new int[]
            {
                8,
                Name.Length + 2,
                Equipment[Slot.Head].Name.Length + 2,
                Equipment[Slot.Body].Name.Length + 2,
                Equipment[Slot.Legs].Name.Length + 2,
                Equipment[Slot.Weapon].Name.Length + 2
            }.Max();
            string dashes1 = new string('-', maxSizeLeft + 1);
            string dashes2 = new string('-', maxSizeRight + 1);
            string spacingSizeRight = maxSizeRight.ToString();
            string spacingSizeLeft = maxSizeLeft.ToString();
            // Sets the format for a line
            string format = $"|{{0,{spacingSizeLeft}}} | {{1,-{spacingSizeRight}}}|";


            sb.AppendFormat($"+{dashes1}+{dashes2}+\n");

            sb.AppendFormat($"{format}\n", this.GetType().Name, Name);

            sb.AppendFormat($"+{dashes1}+{dashes2}+\n");

            sb.AppendFormat($"{format}\n", "Level", Level);
            sb.AppendFormat($"{format}\n", "Strength", TotalPrimaryAttributes.Strength);
            sb.AppendFormat($"{format}\n", "Dexterity", TotalPrimaryAttributes.Dexterity);
            sb.AppendFormat($"{format}\n", "Intelligence", TotalPrimaryAttributes.Intelligence);
            sb.AppendFormat($"{format}\n", "Damage", Damage.ToString("0.00"));

            sb.AppendFormat($"+{dashes1}+{dashes2}+\n");

            sb.AppendFormat($"{format}\n", "Head", Equipment[Slot.Head].Name);
            sb.AppendFormat($"{format}\n", "Body", Equipment[Slot.Body].Name);
            sb.AppendFormat($"{format}\n", "Legs", Equipment[Slot.Legs].Name);
            sb.AppendFormat($"{format}\n", "Weapon", Equipment[Slot.Weapon].Name);

            sb.AppendFormat($"+{dashes1}+{dashes2}+\n");


            Console.WriteLine(sb.ToString());
        }
    }
}
