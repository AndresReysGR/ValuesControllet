using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using web_api_simpsons.Modules;
using web_api_simpsons.Dependencies;

namespace web_api_simpsons.Controllers
{
    [Route("simpsons/[controller]")]
    [ApiController]
    public class CharacterController : ICharacter
    {
        List<Character> listofCharacters=> new List<Character>
        {
            new Character 
            {
                FirstName="Homero",
                SecondName="Jay",
                LastName="Simpson",
                Age= 34,

            },
               new Character 
            {
                FirstName="Bart",
                SecondName="",
                LastName="Simpson",
                Age= 10,

            },
        };
        
        [HttpPost("{id}")]
        public Character GetCharacter(int id)
        {
            return listofCharacters[id];
        }

        [HttpPost]
        public List<Character> GetCharacterList()
        {
            return  listofCharacters; 
        }
    }
}