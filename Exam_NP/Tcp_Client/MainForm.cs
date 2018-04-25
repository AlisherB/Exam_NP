using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tcp_Client
{
    public partial class MainForm : Form
    {
        Client user;
        TcpClient _tcpclient;
        Task thConnect;
        NetworkStream stream;
        byte[] image = { };
        List<string> users = new List<string>();
        public MainForm()
        {
            InitializeComponent();
            Connect();
            thConnect = new Task(new Action(() => { SendMessage(msg_textBox.Text); }));
        }

        private void Connect()
        {
            TcpClient tcpClient = new TcpClient("127.0.0.1", 3081);
            _tcpclient = tcpClient;
        }

        private void SendMessage(string text)
        {
            if (!string.IsNullOrWhiteSpace(msg_textBox.Text))
            {
                text = msg_textBox.Text;
                chat_textBox.Text += "\n" + user.Login + ": " + text;
                byte[] data = Encoding.Unicode.GetBytes(text);
                stream.Write(data, 0, data.Length);
            }
        }

        private void Receive()
        {
            while (true)
            {
                try
                {
                    byte[] data = new byte[256];
                    StringBuilder sb = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        sb.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    } while (stream.DataAvailable);
                    string msg = sb.ToString();
                    lock (chat_textBox)
                    {
                        chat_textBox.Text += "\n" + msg;
                        if (msg == "online")
                        {
                            string[] str = msg.Split(' ');
                            users.Add(str[0]);
                            richTextBox.Clear();
                            foreach (var item in users)
                            {
                                richTextBox.Text += str + "\n";
                            }
                        }
                        else if (msg == "offline")
                        {
                            string[] str = msg.Split(' ');
                            users.Add(str[0]);
                            richTextBox.Clear();
                            foreach (var item in users)
                            {
                                richTextBox.Text += str + "\n";
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    if (stream != null)
                        stream.Close();
                }
            }
        }
        private void SendText_btn_Click(object sender, EventArgs e)
        {
            SendMessage(msg_textBox.Text);
        }
    }
}
