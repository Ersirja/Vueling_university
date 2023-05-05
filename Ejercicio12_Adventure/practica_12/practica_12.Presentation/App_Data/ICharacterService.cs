using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using practica_12.Library.Items;
using practica_12.Library;



namespace WCFService.Presentation
{

    /// <summary>
    /// The place for the contract with character service
    /// </summary>
    [ServiceContract]
    public interface ICharacterService
    {
        [OperationContract]
        Character GetCharacter(string id);

        [OperationContract]
        void AcquireWeapon(string characterId, Weapon Weapon);

        [OperationContract]
        void AcquirePotion(string characterId, Potion Potion);

        [OperationContract]
        void SellItem(string characterId, string itemId);
    }
}

