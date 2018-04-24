namespace ClassLibrary
{
    public class AuthorityService : Service
    {
        public Client AuthorityVerify(string login, string password)
        {
            foreach (var user in Database.GetUsers())
            {
                if (user.Login == login && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
