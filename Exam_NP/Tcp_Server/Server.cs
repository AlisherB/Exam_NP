using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Tcp_Client;
namespace Tcp_Server
{
    public class Server
    {
        TcpListener _listener;
        Database database;
        List<Client> Clients;
        int port = 3080;
        public Server()
        {
            IPHostEntry host = Dns.GetHostEntry("localhost");
            IPAddress ip = host.AddressList[0];
            _listener = new TcpListener(ip, port);
            Clients = new List<Client>();
        }

        public Server(TcpListener listener, Database db)
        {
            _listener = listener;
            database = db;
        }
        
        public delegate void OnDisconnectDelegate(Client cli);
        public event OnDisconnectDelegate OnDisconnect;
        public async void Start()
        {
            try
            {
                _listener.Start();
                Console.WriteLine("Ожидание подключений... " + _listener.LocalEndpoint.AddressFamily.ToString());
                while (true)
                {
                    TcpClient client = await _listener.AcceptTcpClientAsync();
                    AuthorityService auth = new AuthorityService(client, database);
                    Thread th = new Thread(auth.Process);
                    th.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (_listener != null)
                    _listener.Stop();
            }
        }
        
        private void EndReceive(IAsyncResult ar)
        {
            Client client = (Client)ar.AsyncState;
            var readed = client.Socket.EndReceive(ar);
            Client cli = (Client)ar.AsyncState;
            if (readed == 0)
                OnDisconnect.Invoke(cli);
            else
            {
                Console.WriteLine(Encoding.ASCII.GetString(client.Buffer));
                foreach (var c in Clients)
                {
                    if (c.Id != client.Id)
                        SendClient(c, client.Buffer);
                }
                new MemoryStream().Write(client.Buffer, 0, readed);
                client.Socket.BeginReceive(client.Buffer, 0, client.Buffer.Length, SocketFlags.None, EndReceive, client);
            }
        }

        private void SendClient(Client c, byte[] buffer)
        {
            c.Socket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(SendCallback), c);
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                Client client = (Client)ar.AsyncState;
                Socket handler = client.Socket;
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Послано {bytesSent} байтов - {client.Id}.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
