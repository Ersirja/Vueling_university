using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using 

namespace WCFService.Presentation
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    public class CharacterService : ICharacterService
    {
        private readonly ICharacterRepository _characterRepository;

        public CharacterService(ICharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }

        public Character GetCharacter(string id)
        {
            return _characterRepository.Get(id);
        }

        public void AdquirirArma(string characterId, Arma arma)
        {
            var character = _characterRepository.Get(characterId);
            character.AdquirirArma(arma);
            _characterRepository.Save(character);
        }

        public void AdquirirPocion(string characterId, Pocion pocion)
        {
            var character = _characterRepository.Get(characterId);
            character.AdquirirPocion(pocion);
            _characterRepository.Save(character);
        }

        public void VenderItem(string characterId, string itemId)
        {
            var character = _characterRepository.Get(characterId);
            character.VenderItem(itemId);
            _characterRepository.Save(character);
        }
    } 
}