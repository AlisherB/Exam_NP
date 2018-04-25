using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace Tcp_Client
{
    public partial class AuthorityForm : Form
    {
        MainForm mainForm;
        Task threadClient;
        public AuthorityForm()
        {
            InitializeComponent();
            threadClient = new Task(new Action(() => { Connect(login_textBox.Text, password_textBox.Text); }));
            this.Hide();
            mainForm = new MainForm();
        }

        private void Connect_button_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(login_textBox.Text) && string.IsNullOrWhiteSpace(password_textBox.Text)))
            {
                threadClient.Start();
            }
            else MessageBox.Show("Некорректные данные");
        }

        void Connect(string login, string password)
        {
            TcpClient tcpClient = new TcpClient("127.0.0.1", 3080);
            try
            {
                NetworkStream stream = tcpClient.GetStream();
                Client user = new Client()
                {
                    Login = login,
                    Password = password
                };
                string json = JsonConvert.SerializeObject(user);
                byte[] data = Encoding.Default.GetBytes(json);
                stream.Write(data, 0, data.Length);
                data = new byte[1024];
                StringBuilder sb = new StringBuilder();
                int bytes = 0;
                do
                {
                    bytes += stream.Read(data, 0, data.Length);
                    sb.Append(Encoding.Default.GetString(data, 0, bytes));
                } while (stream.DataAvailable);
                user = JsonConvert.DeserializeObject<Client>(sb.ToString());
                if (user != null)
                {
                    mainForm.Client = user;
                    Invoke(new Action(() => mainForm.Show()));
                }
                else MessageBox.Show("УПС!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
