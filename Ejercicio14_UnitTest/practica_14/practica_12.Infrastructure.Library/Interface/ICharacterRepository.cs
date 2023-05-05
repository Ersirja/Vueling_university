using practica_14.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 


namespace practica_14.Infrastructure.Implementations
{

    /// <summary>
    /// THe interface who goes to CharacterRepository
    /// </summary>
    public interface ICharacterRepository
    {
        
        Character GetById(string id);
        void Save(Character character);

        
    }

}
