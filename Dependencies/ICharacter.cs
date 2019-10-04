using System.Collections.Generic;
using web_api_simpsons.Modules;

namespace web_api_simpsons.Dependencies
{
    public interface ICharacter
    {
        List<Character> GetCharacterList();

        Character GetCharacter(int id);
        
    }
}