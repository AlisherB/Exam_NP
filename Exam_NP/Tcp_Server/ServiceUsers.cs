using System;
using Tcp_Client;

namespace Tcp_Server
{
     public class ServiceUsers
     {
        Database database;
        Client currentUser;

        public ServiceUsers()
        {
            database = new Database();
            currentUser = new Client();
        }

        public void AddUser(Client user)
        {
            database.AddUser(user);
        }
        
        public void GetUser(Guid id)
        {
            currentUser = database.GetUser(id);
        }

        public Client CurrentUser()
        {
            return currentUser;
        }
     }
}
