using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testeo_resolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            string screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();
            label1.Text = (screenWidth + "x" + screenHeight);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form2 = new Form();
            form2.StartPosition = FormStartPosition.Manual;
            form2.Left = 200;
            form2.Top = 300;
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            frm.StartPosition = FormStartPosition.Manual;

            frm.Location = new System.Drawing.Point(240, 300);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Left = 300;
            this.Top = 600;
         }

        private void Form1_Load(object sender, EventArgs e)
        {
            string screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            string screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();

            if (screenWidth == "1366")
            {
                MessageBox.Show("1366");
                this.StartPosition = FormStartPosition.Manual;
                this.Left = 300;
                this.Top = 600;
            }

            else
            {
                MessageBox.Show("es otra cosa");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Left = 0;
            this.Top = 0;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Left = 0;
            this.Top = 0;
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Left = 10;
            this.Top = 20;
        }
    }
}
