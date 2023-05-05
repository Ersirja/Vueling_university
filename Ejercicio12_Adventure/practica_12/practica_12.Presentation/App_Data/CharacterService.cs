



using practica_12.Infrastructure.Implementations;
using practica_12.Library;
using practica_12.Library.Items;

namespace WCFService.Presentation
{
    /// <summary>
    /// Service who execute the Character Service
    /// </summary>
    public class CharacterService : ICharacterService
    {
        private readonly ICharacterRepository _characterRepository;

        public CharacterService(ICharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }

        public Character GetCharacter(string id)
        {

            return _characterRepository.GetById(id);
        }

        public void AcquireWeapon(string characterId, Weapon Weapon)
        {
            var character = _characterRepository.GetById(characterId);
            character.AcquireWeapon(Weapon);
            _characterRepository.Save(character);
        }

        public void AcquirePotion(string characterId, Potion Potion)
        {
            var character = _characterRepository.GetById(characterId);
            character.AcquirePotion(Potion);
            _characterRepository.Save(character);
        }

        public void SellItem(string characterId, string itemId)
        {
            var character = _characterRepository.GetById(characterId);
            character.SellItem(itemId);
            _characterRepository.Save(character);
        }
    }

}