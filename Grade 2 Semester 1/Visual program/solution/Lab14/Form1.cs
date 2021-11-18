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
    public partial class Form1 : Form
    {
        TcpListener listener;

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listener = new TcpListener(new IPAddress(new byte[] { 0, 0, 0, 0 }), 1);

            try
            {
                listener.Start();
            }
            catch (SocketException)
            {
                MessageBox.Show("Сервер холбогдох боломжгүй байна.");
            }

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listener.Pending())
            {
                Socket socket = listener.AcceptSocket();
                Form3 form3 = new Form3(socket);
                form3.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void хэрэглэгчНэмэхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

            if (!form2.userName.Equals(null))
            {
                listBox1.Items.Add(form2.userName);
            }
        }

        private void хэрэглэгчХасахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            if (listBox1.SelectedIndex < 0)
                return;
            try
            {
               
                socket.Connect(listBox1.Items[listBox1.SelectedIndex].ToString(), 1);
            }
            catch (SocketException)
            {
                MessageBox.Show("Хосттой холбогдохгүй байна.");
            }
            

            Form3 form3 = new Form3(socket);
            form3.Show();
        }
    }
}
