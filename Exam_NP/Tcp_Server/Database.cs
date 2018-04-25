using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Tcp_Client;

namespace Tcp_Server
{
    public class Database
    {
        public List<Client> Users { get; set; }

        public Database()
        {
            FileStream fs = new FileStream(@"users.json", FileMode.OpenOrCreate);
            using (StreamReader sw = new StreamReader(fs, Encoding.Default))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                Users = (List<Client>)jsonSerializer.Deserialize(sw, typeof(List<Client>));
            }
            if (Users == null)
            {
                Users = new List<Client>();
            }
        }
        public void Init()
        {
            Users = new List<Client>()
            {
                new Client()
                {
                    Id = Guid.NewGuid(),
                    Login = "admin",
                    Password = "admin"
                },
                new Client()
                {
                    Id = Guid.NewGuid(),
                    Login = "User1",
                    Password = "123"
                },
                new Client()
                {
                    Id = Guid.NewGuid(),
                    Login = "User2",
                    Password = "123"
                },
                new Client()
                {
                    Id = Guid.NewGuid(),
                    Login = "Alisher",
                    Password = "123"
                },
            };
        }

        public void AddUser(Client user)
        {
            Users.Add(user);
            JsonSerializer jsonSerializer = new JsonSerializer();
            FileStream fs = new FileStream(@"users.json", FileMode.OpenOrCreate);
            using (StreamWriter streamWriter = new StreamWriter(fs, Encoding.Default))
            {
                using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
                {
                    jsonSerializer.Serialize(jsonWriter, Users);
                }
            }
        }

        public Client GetUser(Guid id)
        {
            foreach (Client user in Users)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            return null;
        }

        public List<Client> GetUsers()
        {
            return Users;
        }

        public bool AuthorityVerify(string login, string password)
        {
            foreach (Client user in Users)
            {
                if (user.Login == login && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
