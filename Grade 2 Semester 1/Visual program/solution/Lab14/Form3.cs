using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Lab14
{
    public partial class Form3 : Form
    {
        Socket socket;

        public Form3(Socket socket)
        {
            InitializeComponent();
            this.socket = socket; 
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            try
            {
                this.Text = Dns.GetHostEntry(((IPEndPoint)socket.RemoteEndPoint).Address).HostName.ToString();
            }
            catch (SocketException)
            {
                MessageBox.Show("Хост олдохгүй байна.");
            }
            catch (NullReferenceException)
            {

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!richTextBox2.Text.Equals(null))
            {
                if (!socket.Connected)
                {
                    MessageBox.Show("Хэрэглэгч холбогдоогүй байна.");
                }

                byte[] data = System.Text.UTF8Encoding.UTF8.GetBytes(richTextBox2.Text);

                try
                {
                    socket.Send(data);
                }
                catch (SocketException)
                { }

                richTextBox1.Text += (Dns.GetHostName() + "> " + richTextBox2.Text + "\n");
                richTextBox2.Clear();
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            socket.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(socket.Available > 0)
            {
                byte[] data = new byte[socket.Available];
                socket.Receive(data);
                richTextBox1.Text += (Dns.GetHostEntry(((IPEndPoint)socket.RemoteEndPoint).Address).HostName + "> " + System.Text.UTF8Encoding.UTF8.GetString(data) + "\n");
            }
        }
    }
}
