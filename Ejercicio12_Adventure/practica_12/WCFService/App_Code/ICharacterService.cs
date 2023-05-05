using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]


public interface ICharacterService
{
    [OperationContract]
    Character GetCharacter(string id);

    [OperationContract]
    void AdquirirArma(string characterId, Arma arma);

    [OperationContract]
    void AdquirirPocion(string characterId, Pocion pocion);

    [OperationContract]
    void VenderItem(string characterId, string itemId);
}


