using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using web_api_simpsons.Modules;
using web_api_simpsons.Dependencies;
using Microsoft.AspNetCore.Cors;
using System.Data.SqlClient;

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
<<<<<<< HEAD
        
        [HttpPost("{id}")]
=======

        string connectionString = @"data source=E321\CITADEL; initial catalog=simpsons; user id=simpsons; password=1234";

        [HttpGet("{id}")]
>>>>>>> ddb486bda8fedc3b47cb232dcc130aae973bd269
        public Character GetCharacter(int id)
        {
            Character character = new Character();
            SqlConnection conn =new SqlConnection(connectionString);
            SqlCommand cmd =new SqlCommand($"select * from tbl_character where id = {id}", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                character = new Character
                {
                    Id = reader.GetInt64(reader.GetOrdinal("id")),
                    FirstName = reader.GetString(reader.GetOrdinal("firstName")),
                    SecondName = reader.GetString(reader.GetOrdinal("secondName")),
                    LastName = reader.GetString(reader.GetOrdinal("lastName")),
                    Age = reader.GetInt32(reader.GetOrdinal("age"))
                 
                };
            }
            return character;
        }

        [HttpPost]
        public List<Character> GetCharacterList()
        {
            List<Character> characters = new List<Character>();
            SqlConnection conn =new SqlConnection(connectionString);
            SqlCommand cmd =new SqlCommand("select * from tbl_character", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                Character character=new Character
                {
                    Id = reader.GetInt64(reader.GetOrdinal("id")),
                    FirstName = reader.GetString(reader.GetOrdinal("firstName")),
                    SecondName = reader.GetString(reader.GetOrdinal("secondName")),
                    LastName = reader.GetString(reader.GetOrdinal("lastName")),
                    Age = reader.GetInt32(reader.GetOrdinal("age"))
                 
                };
                characters.Add(character);
            }
            return  characters; 
        }

   

    }
}