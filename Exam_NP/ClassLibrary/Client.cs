using System;

namespace ClassLibrary
{
    [Serializable]
    public class Client
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Client()
        {
            Id = 1;
            Login = "Client1";
            Password = "123";
        }
        public Client(int id, string login, string password)
        {
            this.Id = id;
            this.Login = login;
            this.Password = password;
        }
    }
    
}
