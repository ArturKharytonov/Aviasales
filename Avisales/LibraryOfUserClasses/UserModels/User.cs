using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibraryOfUserClasses
{
    public class User
    {
        [JsonProperty("User name: ")]
        public string Name { get; set; }

        [JsonProperty("User surname: ")]
        public string Surname { get; set; }
        [JsonProperty("User age: ")]
        public int Age { get; set; }

        [JsonProperty("User login: ")]
        public string Login { get; set; }

        [JsonProperty("User password: ")]
        public string Password { get; set; }


        public User()
        {
            
        }
        public User(string name, string surname, int age, string login, string password)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Login = login;
            Password = password;
        }
    }
}
