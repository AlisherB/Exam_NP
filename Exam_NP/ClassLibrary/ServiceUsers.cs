namespace ClassLibrary
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

        public bool AuthorityVerify(string login, string password)
        {
            if (database.AuthorityVerify(login, password))
            {
                return true;
            }
            return false;
        }

        public void GetUser(int id)
        {
            currentUser = database.GetUser(id);
        }

        public Client CurrentUser()
        {
            return currentUser;
        }
    }
}
