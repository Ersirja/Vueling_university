using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practica_12.Library.Items;

namespace practica_14.Library
/// <summary>
/// All the methods for Main character you build
/// </summary>
{
    public class Character
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Class { get; private set; }
        public string Keyword { get; private set; }
        public int Strength { get; private set; }
        public int Dexterity { get; private set; }
        public int Intelligence { get; private set; }
        public List<Weapon> Weapons { get; private set; }
        public List<Potion> Potions { get; private set; }
        public int Money { get; private set; }

        public Character(string id, string name, string @class, string keyword)
        {
            Id = id;
            Name = name;
            Class = @class;
            Keyword = keyword;
            Weapons = new List<Weapon>();
            Potions = new List<Potion>();
            GenerateRandomStats(keyword);
            Money = 0;
        }




        public void GenerateRandomStats(string palabraClave)
        {
            // Generar estadísticas aleatorias en base a la palabra clave
            Random random = new Random(palabraClave.GetHashCode());
            Strength = random.Next(1, 11);
            Dexterity = random.Next(1, 11);
            Intelligence = random.Next(1, 11);
        }

        public void AcquireWeapon(Weapon Weapon)
        {
            // Verificar que el personaje pueda tener la Weapon
            if (Weapons.Count >= 3)
            {
                // No se puede tener más de 3 Weapons, vender la más antigua
                CheckSales();
            }

            // Agregar la Weapon al inventario del personaje
            Weapons.Add(Weapon);
        }

        public void AcquirePotion(Potion Potion)
        {
            // Verificar que el personaje pueda tener la Potion
            if (Potions.Count >= 5)
            {
                // No se puede tener más de 5 Potions, vender la menos poderosa
                CheckSales();
            }

            // Agregar la Potion al inventario del personaje
            Potions.Add(Potion);
        }


        private void CheckSales()
        {
            // Verificar si se deben vender Weapons o Potions
            if (Weapons.Count >= 3)
            {
                // Vender la Weapon más antigua del inventario del personaje
                Weapons.Sort((a1, a2) => a1.AcquisitionDate.CompareTo(a2.AcquisitionDate));
                Weapon WeaponToSell = Weapons[0];
                Weapons.RemoveAt(0);
                Money += WeaponToSell.SalePrice;
            }

            if (Potions.Count >= 5)
            {
                // Vender la Potion menos poderosa del inventario del personaje
                Potions.Sort((p1, p2) => p1.Power.CompareTo(p2.Power));
                Potion pocionAVender = Potions[0];
                Potions.RemoveAt(0);
                Money += pocionAVender.SalePrice; // Utilizar la propiedad PrecioVenta en la venta de la poción
            }
        }

        public void SellItem(string itemId)
        {
            throw new NotImplementedException();
        }
    }
}
