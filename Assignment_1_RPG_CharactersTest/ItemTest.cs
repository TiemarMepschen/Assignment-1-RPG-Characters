using Assignment_1_RPG_Characters.Characters;
using Assignment_1_RPG_Characters.Items;
using System;
using Xunit;

namespace Assignment_1_RPG_CharactersTest
{
    public class ItemTest
    {
        Warrior warrior = new Warrior();

        Weapon testAxe = new Weapon()
        {
            Name = "Common axe",
            RequiredLevel = 1,
            EquipSlot = Slot.Weapon,
            WeaponType = WeaponType.Axe,
            WeaponAttributes = new WeaponAttributes() { BaseDamage = 7, AttacksPerSecond = 1.1 }
        };

        Armor testPlateBody = new Armor()
        {
            Name = "Common plate body armor",
            RequiredLevel = 1,
            EquipSlot = Slot.Body,
            ArmorType = ArmorType.Plate,
            Attributes = new PrimaryAttributes() { Strength = 1 }
        };

        Weapon testBow = new Weapon()
        {
            Name = "Common bow",
            RequiredLevel = 1,
            EquipSlot = Slot.Weapon,
            WeaponType = WeaponType.Bow,
            WeaponAttributes = new WeaponAttributes() { BaseDamage = 12, AttacksPerSecond = 0.8 }
        };

        Armor testClothHead = new Armor()
        {
            Name = "Common cloth head armor",
            RequiredLevel = 1,
            EquipSlot = Slot.Head,
            ArmorType = ArmorType.Cloth,
            Attributes = new PrimaryAttributes() { Intelligence = 5 }
        };

        [Fact]
        public void EquipWeapon_EquipsHigherLevelWeapon_ShoudThrowInvalidWeaponException()
        {
            // Arrange
            testAxe.RequiredLevel = 2;

            // Act

            // Assert
            Assert.Throws<InvalidWeaponException>(() => warrior.equip(Slot.Weapon, testAxe));
        }

        [Fact]
        public void EquipArmor_EquipsHigherLevelArmor_ShoudThrowInvalidArmorException()
        {
            // Arrange
            testPlateBody.RequiredLevel = 2;

            // Act

            // Assert
            Assert.Throws<InvalidArmorException>(() => warrior.equip(Slot.Body, testPlateBody));
        }

        [Fact]
        public void EquipWeapon_EquipsInvalidWeaponType_ShoudThrowInvalidWeaponException()
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<InvalidWeaponException>(() => warrior.equip(Slot.Weapon, testBow));
        }

        [Fact]
        public void EquipArmor_EquipsInvalidArmorType_ShoudThrowInvalidArmorException()
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<InvalidArmorException>(() => warrior.equip(Slot.Head, testClothHead));
        }

        [Fact]
        public void EquipWeapon_EquipsInInvalidSlot_ShoudThrowInvalidWeaponException()
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<InvalidWeaponException>(() => warrior.equip(Slot.Legs, testAxe));
        }

        [Fact]
        public void EquipArmor_EquipsInInvalidSlot_ShoudThrowInvalidArmorException()
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<InvalidArmorException>(() => warrior.equip(Slot.Head, testPlateBody));
        }

        [Fact]
        public void EquipWeapon_EquipsValidWeapon_ShoudReturnSuccesString()
        {
            // Arrange
            string expected = "New weapon equipped!";

            // Act
            string actual = warrior.equip(Slot.Weapon, testAxe);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EquipArmor_EquipsValidArmor_ShoudReturnSuccesString()
        {
            // Arrange
            string expected = "New armor equipped!";

            // Act
            string actual = warrior.equip(Slot.Body, testPlateBody);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Damage_CalculatesDamageNoWeapon_ShouldReturnBaseDamage()
        {
            // Arrange
            double expected = 1*(1 + (double)5/100);

            // Act
            double actual = warrior.Damage;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Damage_CalculatesDamageWithWeapon_ShouldReturnUpdatedDamage()
        {
            // Arrange
            warrior.equip(testAxe);
            double expected = 7 * 1.1 * (1 + (double)5/100);

            // Act
            double actual = warrior.Damage;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Damage_CalculatesDamageWithWeaponAndArmor_ShouldReturnUpdatedDamage()
        {
            // Arrange
            warrior.equip(testPlateBody);
            warrior.equip(testAxe);
            double expected = 7 * 1.1 * (1 + (double)(5 + 1) / 100);

            // Act
            double actual = warrior.Damage;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}