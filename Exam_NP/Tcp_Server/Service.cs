namespace Tcp_Server
{
     public abstract class Service
    {
        public Database Database { get; set; }

        public Service()
        {
            Database = new Database();
        }
    }
}
