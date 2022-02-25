using Assignment_1_RPG_Characters.Characters;
using System;
using Xunit;

namespace Assignment_1_RPG_CharactersTest
{
    public class CharacterTest
    {
        [Fact]
        public void MageConstructor_AssignsLevelToMage_ShouldReturnOne()
        {
            // Arrange
            int expected = 1;

            // Act
            int actual = new Mage().Level;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RangerLevelUp_LevelsUpCharacter_ShouldReturnTwo()
        {
            // Arrange
            int expected = 2;

            // Act
            Ranger ranger = new Ranger();
            ranger.levelUp();
            int actual = ranger.Level;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MageBaseStrength_SetsBaseAttributes_ShouldReturnBaseStrength()
        {
            // Arrange
            int expected = 1;

            // Act
            Mage mage = new Mage();
            int actual = mage.BasePrimaryAttributes.Strength;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MageBaseDexterity_SetsBaseAttributes_ShouldReturnBaseDexterity()
        {
            // Arrange
            int expected = 1;

            // Act
            Mage mage = new Mage();
            int actual = mage.BasePrimaryAttributes.Dexterity;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MageBaseIntelligence_SetsBaseAttributes_ShouldReturnBaseIntelligence()
        {
            // Arrange
            int expected = 8;

            // Act
            Mage mage = new Mage();
            int actual = mage.BasePrimaryAttributes.Intelligence;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RangerBaseStrength_SetsBaseAttributes_ShouldReturnBaseStrength()
        {
            // Arrange
            int expected = 1;

            // Act
            Ranger ranger = new Ranger();
            int actual = ranger.BasePrimaryAttributes.Strength;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RangerBaseDexterity_SetsBaseAttributes_ShouldReturnBaseDexterity()
        {
            // Arrange
            int expected = 7;

            // Act
            Ranger ranger = new Ranger();
            int actual = ranger.BasePrimaryAttributes.Dexterity;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RangerBaseIntelligence_SetsBaseAttributes_ShouldReturnBaseIntelligence()
        {
            // Arrange
            int expected = 1;

            // Act
            Ranger ranger = new Ranger();
            int actual = ranger.BasePrimaryAttributes.Intelligence;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RogueBaseStrength_SetsBaseAttributes_ShouldReturnBaseStrength()
        {
            // Arrange
            int expected = 2;

            // Act
            Rogue rogue = new Rogue();
            int actual = rogue.BasePrimaryAttributes.Strength;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RogueBaseDexterity_SetsBaseAttributes_ShouldReturnBaseDexterity()
        {
            // Arrange
            int expected = 6;

            // Act
            Rogue rogue = new Rogue();
            int actual = rogue.BasePrimaryAttributes.Dexterity;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RogueBaseIntelligence_SetsBaseAttributes_ShouldReturnBaseIntelligence()
        {
            // Arrange
            int expected = 1;

            // Act
            Rogue rogue = new Rogue();
            int actual = rogue.BasePrimaryAttributes.Intelligence;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WarriorBaseStrength_SetsBaseAttributes_ShouldReturnBaseStrength()
        {
            // Arrange
            int expected = 5;

            // Act
            Warrior warrior = new Warrior();
            int actual = warrior.BasePrimaryAttributes.Strength;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WarriorBaseDexterity_SetsBaseAttributes_ShouldReturnBaseDexterity()
        {
            // Arrange
            int expected = 2;

            // Act
            Warrior warrior = new Warrior();
            int actual = warrior.BasePrimaryAttributes.Dexterity;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WarriorBaseIntelligence_SetsBaseAttributes_ShouldReturnBaseIntelligence()
        {
            // Arrange
            int expected = 1;

            // Act
            Warrior warrior = new Warrior();
            int actual = warrior.BasePrimaryAttributes.Intelligence;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MageLevelUpStrength_AddsNewAttributes_ShouldReturnTotalPrimaryStrength()
        {
            // Arrange
            int expected = 2;

            // Act
            Mage mage = new Mage();
            mage.levelUp();
            int actual = mage.TotalPrimaryAttributes.Strength;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MageLevelUpDexterity_AddsNewAttributes_ShouldReturnTotalPrimaryDexterity()
        {
            // Arrange
            int expected = 2;

            // Act
            Mage mage = new Mage();
            mage.levelUp();
            int actual = mage.TotalPrimaryAttributes.Dexterity;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MageLevelUpIntelligence_AddsNewAttributes_ShouldReturnTotalPrimaryIntelligence()
        {
            // Arrange
            int expected = 13;

            // Act
            Mage mage = new Mage();
            mage.levelUp();
            int actual = mage.TotalPrimaryAttributes.Intelligence;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RangerLevelUpStrength_AddsNewAttributes_ShouldReturnTotalPrimaryStrength()
        {
            // Arrange
            int expected = 2;

            // Act
            Ranger ranger = new Ranger();
            ranger.levelUp();
            int actual = ranger.TotalPrimaryAttributes.Strength;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RangerLevelUpDexterity_AddsNewAttributes_ShouldReturnTotalPrimaryDexterity()
        {
            // Arrange
            int expected = 12;

            // Act
            Ranger ranger = new Ranger();
            ranger.levelUp();
            int actual = ranger.TotalPrimaryAttributes.Dexterity;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RangerLevelUpIntelligence_AddsNewAttributes_ShouldReturnTotalPrimaryIntelligence()
        {
            // Arrange
            int expected = 2;

            // Act
            Ranger ranger = new Ranger();
            ranger.levelUp();
            int actual = ranger.TotalPrimaryAttributes.Intelligence;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RogueLevelUpStrength_AddsNewAttributes_ShouldReturnTotalPrimaryStrength()
        {
            // Arrange
            int expected = 3;

            // Act
            Rogue rogue = new Rogue();
            rogue.levelUp();
            int actual = rogue.TotalPrimaryAttributes.Strength;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RogueLevelUpDexterity_AddsNewAttributes_ShouldReturnTotalPrimaryDexterity()
        {
            // Arrange
            int expected = 10;

            // Act
            Rogue rogue = new Rogue();
            rogue.levelUp();
            int actual = rogue.TotalPrimaryAttributes.Dexterity;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RogueLevelUpIntelligence_AddsNewAttributes_ShouldReturnTotalPrimaryIntelligence()
        {
            // Arrange
            int expected = 2;

            // Act
            Rogue rogue = new Rogue();
            rogue.levelUp();
            int actual = rogue.TotalPrimaryAttributes.Intelligence;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WarriorLevelUpStrength_AddsNewAttributes_ShouldReturnTotalPrimaryStrength()
        {
            // Arrange
            int expected = 8;

            // Act
            Warrior warrior = new Warrior();
            warrior.levelUp();
            int actual = warrior.TotalPrimaryAttributes.Strength;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WarriorLevelUpDexterity_AddsNewAttributes_ShouldReturnTotalPrimaryDexterity()
        {
            // Arrange
            int expected = 4;

            // Act
            Warrior warrior = new Warrior();
            warrior.levelUp();
            int actual = warrior.TotalPrimaryAttributes.Dexterity;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WarriorLevelUpIntelligence_AddsNewAttributes_ShouldReturnTotalPrimaryIntelligence()
        {
            // Arrange
            int expected = 2;

            // Act
            Warrior warrior = new Warrior();
            warrior.levelUp();
            int actual = warrior.TotalPrimaryAttributes.Intelligence;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
