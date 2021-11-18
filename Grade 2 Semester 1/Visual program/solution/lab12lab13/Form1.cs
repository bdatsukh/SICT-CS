using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace lab12lab13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread4 = new Thread(t => {
                while (true)
                {
                    label1.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate
                    () { label1.Text = Convert.ToString(DateTime.Now.TimeOfDay); });
                   
                    richTextBox1.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate
                        (){ richTextBox1.Text += (label1.Text + '\n'); });

                    Thread.Sleep(1000);
                }
            })
            { IsBackground = true };
            thread4.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0, y = panel1.Height;

            Thread thread = new Thread(t => {
                while(true)
                {
                    if (x >= panel1.Width || y <= 0)
                    {
                        x = 0;
                        y = panel1.Height;
                    }
                    for (int i = 10; i < 200; i += 10)
                    {
                        panel1.CreateGraphics().DrawEllipse(new Pen(Brushes.Blue, 1), new
                    Rectangle(x - (i * 3), y + (i * 3), 10, 10));
                    }
                    panel1.CreateGraphics().DrawEllipse(new Pen(Brushes.Black, 1), new
                    Rectangle(x, y, 10, 10));
                    Thread.Sleep(100);
                    panel1.CreateGraphics().Clear(panel1.BackColor);

                    x += 10;
                    y -= 10;
                }
            })
            { IsBackground = true };
            thread.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}