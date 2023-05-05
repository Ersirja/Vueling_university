using practica_14.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practica_14.Infrastructure.Implementations;


namespace practica_14.Infrastructure.Library
{

    /// <summary>
    ///  A class that implements the repository for the Character   
    /// </summary>
    public class CharacterRepository : ICharacterRepository
    {
        private readonly List<Character> _characters;

        public CharacterRepository()
        {
            _characters = new List<Character>();
        }

        public Character GetById(string id)
        {
            return _characters.FirstOrDefault(c => c.Id == id);
        }

        public void Save(Character character)
        {
            if (_characters.Any(c => c.Id == character.Id))
            {


                // Update existing character
                var existingCharacter = _characters.FirstOrDefault(c => c.Id == character.Id);
                _characters.Remove(existingCharacter);
            }

            // Add new character
            _characters.Add(character);
        }
    }
}
