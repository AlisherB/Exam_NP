using System;
using System.Net.Sockets;
namespace Tcp_Client
{
    public class Client
    {
        private byte[] buff = new byte[1024];

        public byte[] Buffer { get => buff; set => buff = value; }
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Socket Socket { get; set; }
        
        public override string ToString()
        {
            return String.Format($"{this.Socket.RemoteEndPoint.ToString()}:{this.Id}");
        }
    }
}
