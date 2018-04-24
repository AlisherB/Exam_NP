using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ClassLibrary
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Connect(string server, string text)
        {
            try
            {
                int port = 3080;
                TcpClient client = new TcpClient(server, port);
                byte[] data = Encoding.ASCII.GetBytes(text);

                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                Console.WriteLine("Send: {0}", text);

                data = new byte[256];
                var response = string.Empty;
                var bytes = stream.Read(data, 0, data.Length);
                response = Encoding.ASCII.GetString(data, 0, bytes);
                Console.WriteLine("Received: {0}", response);
                client.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Login_button_Click(object sender, EventArgs e)
        {

        }

        private void Logout_button_Click(object sender, EventArgs e)
        {

        }

        private void SendText_button_Click(object sender, EventArgs e)
        {

        }

        private void SendImage_button_Click(object sender, EventArgs e)
        {

        }
    }
}
