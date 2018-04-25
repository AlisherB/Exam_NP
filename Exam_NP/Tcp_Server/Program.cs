using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tcp_Server
{
    class Program
    {
        static Server server;
        static Database db;
        static void Main(string[] args)
        {
            try
            {
                db = new Database();
                server = new Server();
                db.Init();
                server.Start();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }
    }
}
