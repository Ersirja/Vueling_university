using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practica_14.Library.Items.;

namespace Testing
{
    [TestFixture]
    public class CharacterTests
    {
        [Test]
        public void TestGenerateRandomStats()
        {
            // Arrange
            string palabraClave = "test";
            Character character = new Character("1", "Test Character", "Warrior", palabraClave);

            // Act
            character.GenerateRandomStats(palabraClave);

            // Assert
            Assert.That(character.Strength >= 1 && character.Strength <= 10);
            Assert.That(character.Dexterity >= 1 && character.Dexterity <= 10);
            Assert.That(character.Intelligence >= 1 && character.Intelligence <= 10);
        }

        [Test]
        public void TestAcquireWeapon()
        {
            // Arrange
            Character character = new Character("1", "Test Character", "Warrior", "test");
            Weapon weapon = new Weapon("1", "Test Weapon", 10, 5, 50);

            // Act
            character.AcquireWeapon(weapon);

            // Assert
            Assert.That(character.Weapons.Count == 1);
            Assert.That(character.Weapons[0] == weapon);
        }

        [Test]
        public void TestAcquirePotion()
        {
            // Arrange
            Character character = new Character("1", "Test Character", "Warrior", "test");
            Potion potion = new Potion("1", "Test Potion", 10, 5, 50);

            // Act
            character.AcquirePotion(potion);

            // Assert
            Assert.That(character.Potions.Count == 1);
            Assert.That(character.Potions[0] == potion);
        }

        [Test]
        public void TestCheckSales()
        {
            // Arrange
            Character character = new Character("1", "Test Character", "Warrior", "test");
            Weapon weapon1 = new Weapon("1", "Test Weapon 1", 10, 5, 50);
            Weapon weapon2 = new Weapon("2", "Test Weapon 2", 8, 4, 40);
            Weapon weapon3 = new Weapon("3", "Test Weapon 3", 12, 6, 60);
            Potion potion1 = new Potion("1", "Test Potion 1", 10, 5, 50);
            Potion potion2 = new Potion("2", "Test Potion 2", 8, 4, 40);
            Potion potion3 = new Potion("3", "Test Potion 3", 12, 6, 60);

            character.AcquireWeapon(weapon1);
            character.AcquireWeapon(weapon2);
            character.AcquireWeapon(weapon3);
            character.AcquirePotion(potion1);
            character.AcquirePotion(potion2);
            character.AcquirePotion(potion3);

            // Act
            character.CheckSales();

            // Assert
            Assert.That(character.Weapons.Count == 3);
            Assert.That(character.Potions.Count == 2);
        }
    }
}

    
