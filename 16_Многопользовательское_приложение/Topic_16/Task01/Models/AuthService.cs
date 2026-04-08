using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task01.Models
{
    public class AuthService
    {
        public User Login(string login, string password)
        {
            var json = File.ReadAllText("users.json");
            var users = JsonSerializer.Deserialize<List<User>>(json);

            return users.FirstOrDefault(u =>
                u.Login == login && u.Password == password);
        }
    }
}
