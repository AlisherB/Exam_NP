using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClassLibrary
{
    public class Database
    {
        private List<Client> users;

        public Database()
        {
            users = new List<Client>();
            FileStream fs = new FileStream(@"users.json", FileMode.OpenOrCreate);
            using (StreamReader sw = new StreamReader(fs, Encoding.Default))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                users = (List<Client>)jsonSerializer.Deserialize(sw, typeof(List<Client>));
            }
            if (users == null)
            {
                users = new List<Client>();
            }
        }

        public void AddUser(Client user)
        {
            users.Add(user);
            JsonSerializer jsonSerializer = new JsonSerializer();
            FileStream fs = new FileStream(@"users.json", FileMode.OpenOrCreate);
            using (StreamWriter streamWriter = new StreamWriter(fs, Encoding.Default))
            {
                using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
                {
                    jsonSerializer.Serialize(jsonWriter, users);
                }
            }
        }

        public Client GetUser(int id)
        {
            foreach (Client user in users)
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
            return users;
        }

        public bool AuthorityVerify(string login, string password)
        {
            foreach (Client user in users)
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
