using static System.Console;
using System.Net.Sockets;
using Tcp_Client;
using System.Text;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace Tcp_Server
{
    public class AuthorityService : Service
    {
        TcpClient tcpClient;
        Database database;
        public AuthorityService(TcpClient client, Database db)
        {
            tcpClient = client;
            database = db;
        }
        public async void Process()
        {
            TcpClient client = tcpClient;
            using (NetworkStream stream = client.GetStream())
            {
                byte[] data = new byte[1024];
                while (true)
                {
                    Client user = null;
                    int bytes = 0;
                    do
                    {
                        bytes += await stream.ReadAsync(data, 0, data.Length);
                    } while (stream.DataAvailable);
                    WriteLine("Прочтено {0} байтов", bytes);
                    if (bytes > 0)
                    {
                        string json = Encoding.Default.GetString(data, 0, bytes);
                        user = JsonConvert.DeserializeObject<Client>(json);
                        if (AuthorityVerify(user))
                        {
                            user = database.Users.Find((x) => x.Login == user.Login);
                            json = JsonConvert.SerializeObject(user);
                            data = Encoding.Default.GetBytes(json);
                        }
                        else data = Encoding.Default.GetBytes(string.Empty);
                        await stream.WriteAsync(data, 0, data.Length);
                    }
                }
            }
        }

        public bool AuthorityVerify(Client user)
        {
            if (Authority(user))
            {
                Client _user = database.Users.First((x) => x.Password == user.Password);
                if (_user != null)
                    return true;
                return false;
            }
            return false;
        }

        private bool Authority(Client user)
        {
            return database.Users.Exists((x) => x.Login == user.Login);
        }
    }
}
