using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Models
{
    public class AuthService
    {
        private readonly string file = "users.json";
        public List<UserModel> LoadUsers()
        {
            if (!File.Exists(file))
                return new List<UserModel>();

            var json = File.ReadAllText(file);
            return JsonConvert.DeserializeObject<List<UserModel>>(json);
        }

        public UserModel Login(string login, string password)
        {
            var users = LoadUsers();
            return users.FirstOrDefault(u =>
                u.Login == login && u.Password == password);
        }
    }
}
